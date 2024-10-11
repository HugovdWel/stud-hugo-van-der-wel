using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public EnemyAttackSettings enemyAttackSettings;

    public delegate void TargetLock(GameObject attacker, bool lockIsActive);

    public float moveSpeed;
    public string targetName;
    public int numberOfLives;
    public static event TargetLock SetTargetLock;

    private Rigidbody _rb;
    private GameObject _target;
    private float _targetLockAcquiredTime;
    private JumpController _jumpController;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _target = GameObject.Find(targetName);
        _targetLockAcquiredTime = 0;
        _jumpController = GetComponent<JumpController>();
        StartCoroutine(CheckIfWithinAttackRange());
    }

    private void OnDestroy()
    {
        SetTargetLock?.Invoke(gameObject, false);
    }

    private void FixedUpdate()
    {
        if (_targetLockAcquiredTime != 0) return;

        var ownPosition = transform.position;
        var movementDirection = (_target.transform.position - ownPosition).normalized;
        movementDirection.y = 0;

        _rb.MovePosition(ownPosition + movementDirection * moveSpeed);
        _rb.MoveRotation(Quaternion.LookRotation(movementDirection, transform.up));
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        _jumpController.AddGameObjectToJumpableTerrainsListIfItIsJumpable(collision.gameObject);
    }

    private void OnCollisionExit(Collision collision)
    {
        _jumpController.RemoveGameObjectFromJumpableTerrainsListIfItIsInThere(collision.gameObject);
    }

    private void OnTriggerEnter(Collider triggerCollider)
    {
        if (!triggerCollider.gameObject.CompareTag(enemyAttackSettings.attackProjectileTag)) return;

        _rb.AddForce(
            triggerCollider.attachedRigidbody.velocity.normalized *
            triggerCollider.gameObject.GetComponent<ProjectileController>().pushBackForce,
            ForceMode.Impulse);

        Destroy(triggerCollider.gameObject);
        numberOfLives--;
        if (numberOfLives == 0)
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator CheckIfWithinAttackRange()
    {
        while (enabled)
        {
            if (_targetLockAcquiredTime == 0 &&
                Vector3.Distance(transform.position, _target.transform.position) < enemyAttackSettings.attackRange)
            {
                StartCoroutine(ExecuteTargetLockState());

                yield return new WaitForSeconds(enemyAttackSettings.targetLockDuration);
            }

            yield return null;
        }
    }

    private IEnumerator ExecuteTargetLockState()
    {
        SetTargetLock?.Invoke(gameObject, true);
        _targetLockAcquiredTime = Time.time;
        while (_targetLockAcquiredTime != 0)
        {
            if (_targetLockAcquiredTime < Time.time - enemyAttackSettings.attackDuration)
            {
                _targetLockAcquiredTime = 0;
                SetTargetLock?.Invoke(gameObject, false);
            }
            else if (_jumpController.IsJumpStateStartingToJump())
            {
                _jumpController.Jump(_rb);
            }
            else
            {
                _jumpController.JumpIfOnGround();
            }

            yield return null;
        }
    }
}