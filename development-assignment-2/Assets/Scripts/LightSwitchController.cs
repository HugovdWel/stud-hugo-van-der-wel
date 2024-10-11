using System.Net.Http.Headers;
using UnityEngine;

public class LightSwitchController : MonoBehaviour, INteractable
{
    public bool initialStateOn;
    public float leverSwitchAngle;
    public GameObject movingLever;
    public GameObject handle;
    public Material handleOnMaterial;
    public Material handleOffMaterial;

    public delegate void LightState(bool setStateOn);

    public static event LightState SetLightState;

    private bool _currentState; //on = true, off = false

    private void Start()
    {
        _currentState = initialStateOn;
        SetState(_currentState);
    }

    private void OnEnable()

    {
        SetLightState += SetState;
    }

    private void OnDisable()
    {
        SetLightState -= SetState;
    }

    public void Interact()
    {
        SwitchState();
        SetLightState?.Invoke(_currentState);
    }

    private void SwitchState()
    {
        _currentState = !_currentState;
        SetState(_currentState);
    }

    private void SetState(bool state)
    {
        movingLever.transform.localRotation = Quaternion.identity;

        movingLever.transform.Rotate(state
            ? new Vector3(0, 0, leverSwitchAngle)
            : new Vector3(0, 0, -leverSwitchAngle));

        handle.GetComponent<Renderer>().material = state ? handleOffMaterial : handleOnMaterial;
    }
}