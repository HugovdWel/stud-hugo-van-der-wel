using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float maxSpeed;
    public float midAirMovementMultiplier;
    public float interactRange;
    public EnemyAttackSettings enemyAttackSettings;
    public string interactableTag;

    private JumpController _jumpController;
    private PlayerAttackManager _playerAttackManager;
    private Rigidbody _rb;
    private Vector3 _movement;
    private float _movementRotation;
    private List<GameObject> _currentTargetLockedEnemies;
    private GameObject _attackArea;
    private Transform _attackFieldTransform;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _playerAttackManager = GetComponent<PlayerAttackManager>();
        _jumpController = GetComponent<JumpController>();
        _currentTargetLockedEnemies = new List<GameObject>();
    }

    private void Update()
    {
        //jump
        if (_jumpController.IsJumpStateStartingToJump())
        {
            _jumpController.Jump(_rb);
        }
    }

    private void FixedUpdate()
    {
        //move
        if (_jumpController.IsCurrentlyOfGround())
        {
            _rb.AddForce(transform.TransformDirection(_movement * movementSpeed), ForceMode.VelocityChange);
        }
        else
        {
            _rb.AddForce(transform.TransformDirection(_movement * (movementSpeed * midAirMovementMultiplier)),
                ForceMode.VelocityChange);
        }

        if (_rb.velocity.magnitude > maxSpeed)
        {
            _rb.velocity = _rb.velocity.normalized * maxSpeed;
        }


        //turn
        _rb.freezeRotation = false;
        _rb.MoveRotation(_rb.rotation * Quaternion.Euler(new Vector3(0, _movementRotation * rotationSpeed, 0)));
        _rb.freezeRotation = true;

        //attackProcessing
        
        if (_attackFieldTransform != null)
        {
            _rb.AddForce(2 * Physics.gravity.magnitude * _attackFieldTransform.up, ForceMode.Acceleration);
        }
    }

    private void OnEnable()
    {
        EnemyController.SetTargetLock += GetTargetLocked;
    }

    private void OnDisable()
    {
        EnemyController.SetTargetLock -= GetTargetLocked;
    }

    private void OnMove(InputValue movementValue)
    {
        var movementVector = movementValue.Get<Vector2>();
        _movement = new Vector3(movementVector.x, 0, movementVector.y);
    }

    private void OnTurn(InputValue turnValue)
    {
        var turnAxis = turnValue.Get<Vector2>();
        _movementRotation = turnAxis.x;
    }

    private void OnJump(InputValue value)
    {
        _jumpController.JumpIfOnGround();
    }

    private void OnFire(InputValue value)
    {
        FireCube();
    }
    
    private void OnInteract(InputValue value)
    {
        if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out var hit,
                interactRange)) return;
        
        if (hit.transform.CompareTag(interactableTag))
        {
            hit.transform.gameObject.GetComponent<INteractable>().Interact();
        }
    }
    
    private void FireCube()
    {
        _playerAttackManager.FireProjectileFromTransform(transform);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _jumpController.AddGameObjectToJumpableTerrainsListIfItIsJumpable(collision.gameObject);
    }

    private void OnCollisionExit(Collision collision)
    {
        _jumpController.RemoveGameObjectFromJumpableTerrainsListIfItIsInThere(collision.gameObject);
    }

    private void GetTargetLocked(GameObject attacker, bool lockIsActive)
    {
        if (lockIsActive)
        {
            _currentTargetLockedEnemies.Add(attacker);
        }
        else
        {
            _currentTargetLockedEnemies.Remove(attacker);
        }

        if (_currentTargetLockedEnemies.Count >= enemyAttackSettings.simultaneousTargetLocksRequiredForAttack)
        {
            startAttackOnPlayer();
        }
    }

    private void startAttackOnPlayer()
    {
        if (_attackArea != null)
        {
            Destroy(_attackArea);
            _attackArea = null;
        }

        Vector3 pointAttackTowards = (enemyAttackSettings.pointThatFieldDirectsPlayerTo - transform.position).normalized;

        _attackArea = Instantiate(enemyAttackSettings.attackAreaPrefab, transform.position, Quaternion.LookRotation(pointAttackTowards));
        _attackArea.transform.localScale = new Vector3(enemyAttackSettings.attackSize,
            enemyAttackSettings.attackSize * 2,
            enemyAttackSettings.attackSize);
    }

    private void OnTriggerEnter(Collider triggerCollider)
    {
        if (triggerCollider.gameObject.CompareTag(enemyAttackSettings.attackAreaTag))
        {
            _attackFieldTransform = triggerCollider.gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider triggerCollider)
    {
        if (triggerCollider.gameObject.CompareTag(enemyAttackSettings.attackAreaTag))
        {
            _attackFieldTransform = null;
        }
    }
}