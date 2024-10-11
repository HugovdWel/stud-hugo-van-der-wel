using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public int viewRangeDownwards;
    public int viewRangeUpwards;
    public float moveSpeed;
    public float gravityStrength;
    private CharacterController _characterController;
    private Light _light;
    private Animator _animator;
    private bool _chatBoxOpen;
    public string enemyTag;
    public float lightParalyzingRange;
    private VariableDeclarations _currentlyParalyzingEnemyDeclaration;
    private Vector3 _movement;
    private Vector2 _viewVector;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
        _light = GetComponentInChildren<Light>();
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(StunEnemiesInLight());
    }

    private void FixedUpdate()
    {
        Vector3 movementVector =
            transform.TransformDirection(new Vector3(_movement.x * moveSpeed, gravityStrength * -1,
                _movement.z * moveSpeed));
        _animator.SetFloat("forwardSpeed", _movement.z);
        _animator.SetFloat("sideSpeed", _movement.x);
        _characterController.Move(movementVector);
        transform.Rotate(new Vector3(0, _viewVector.x, 0));
    }

    public void OnMove(InputValue moveVector)
    {
        var inputVector = moveVector.Get<Vector2>();
        _movement = new Vector3(inputVector.x, 0, inputVector.y);
    }

    public void OnLook(InputValue lookVector)
    {
        var vec = lookVector.Get<Vector2>();
        _viewVector = new Vector2(vec.x, vec.y);
    }

    public void OnFire(InputValue fireValue)
    {
        _light.enabled = !_light.enabled;
    }

    private IEnumerator StunEnemiesInLight()
    {
        while (true)
        {
            if (_currentlyParalyzingEnemyDeclaration != null)
            {
                _currentlyParalyzingEnemyDeclaration["Stunned"] = false;
            }

            if (_light.enabled)
            {
                if (Physics.Raycast(_light.gameObject.transform.position, _light.gameObject.transform.forward,
                        out RaycastHit hit, lightParalyzingRange))
                {

                    if (hit.collider.CompareTag(enemyTag))
                    {
                        _currentlyParalyzingEnemyDeclaration = hit.collider.GetComponent<Variables>().declarations;
                        _currentlyParalyzingEnemyDeclaration["Stunned"] = true;
                    }
                    else
                    {
                        _currentlyParalyzingEnemyDeclaration = null;
                    }
                }
                else
                {
                    _currentlyParalyzingEnemyDeclaration = null;
                }
            }

            yield return null;
        }
    }
}