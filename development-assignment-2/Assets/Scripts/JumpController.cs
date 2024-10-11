using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    public float jumpStrength;
    public int jumpableLayer;
    private JumpState _currentJumpState;

    private List<GameObject> _currentlyTouchingTerrains;

    private enum JumpState
    {
        ReadyToJump,
        StartingJump,
        InTheAir,
    }

    private void Start()
    {
        _currentlyTouchingTerrains = new List<GameObject>();
        _currentJumpState = JumpState.InTheAir;
    }

    public void Jump(Rigidbody rigidbodyToJump)
    {
        rigidbodyToJump.AddForce(new Vector3(0, jumpStrength, 0), ForceMode.Impulse);
        _currentJumpState = JumpState.InTheAir;
    }

    public void JumpIfOnGround()
    {
        if (_currentJumpState == JumpState.ReadyToJump)
        {
            _currentJumpState = JumpState.StartingJump;
        }
    }
    public bool IsCurrentlyOfGround()
    {
        return _currentJumpState == JumpState.ReadyToJump;
    }

    public void AddGameObjectToJumpableTerrainsListIfItIsJumpable(GameObject collisionGameObject)
    {
        if (collisionGameObject.gameObject.layer != jumpableLayer) return;

        _currentlyTouchingTerrains.Add(collisionGameObject.gameObject);
        _currentJumpState = JumpState.ReadyToJump;
    }

    public void RemoveGameObjectFromJumpableTerrainsListIfItIsInThere(GameObject collisionGameObject)
    {
        if (collisionGameObject.gameObject.layer != jumpableLayer) return;
        _currentlyTouchingTerrains.Remove(collisionGameObject.gameObject);

        if (_currentlyTouchingTerrains.Count != 0) return;
        _currentJumpState = JumpState.InTheAir;
    }

    public bool IsJumpStateStartingToJump()
    {
        return _currentJumpState == JumpState.StartingJump;
    }
}