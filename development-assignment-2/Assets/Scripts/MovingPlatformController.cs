using System;
using System.Collections;
using UnityEngine;

public class MovingPlatformController : MonoBehaviour
{
    public Vector3 relativeEndPosition;
    public float travelTime;
    public float waitTime;
    public float blinkTime;
    public Material lightOnMaterial;
    public Material lightOffMaterial;

    private Vector3 _startPosition;
    private Rigidbody _rb;
    private Vector3 _movementPerDeltaTime;
    private PlatformState _currentPlatformState;
    private float _timeAtStateEntry;
    private Light _light;
    private Renderer _renderer;

    private enum PlatformState
    {
        MovingTowardsPoint1,
        MovingTowardsPoint2,
        WaitingAtPoint1,
        WaitingAtPoint2,
    }

    private void Start()
    {
        _currentPlatformState = PlatformState.MovingTowardsPoint2;
        _startPosition = transform.position;
        _rb = GetComponent<Rigidbody>();

        _movementPerDeltaTime = relativeEndPosition / (travelTime / 0.02f);
        _timeAtStateEntry = Time.fixedTime;
        _light = GetComponent<Light>();
        _renderer = GetComponent<Renderer>();
        StartCoroutine(Blink());
    }

    private void Update()
    {
        switch (_currentPlatformState)
        {
            case PlatformState.MovingTowardsPoint1:
                if (Time.fixedTime >= _timeAtStateEntry + travelTime)
                {
                    _timeAtStateEntry = Time.fixedTime;
                    _currentPlatformState = PlatformState.WaitingAtPoint1;
                    _rb.MovePosition(_startPosition);
                    _movementPerDeltaTime = new Vector3(0, 0, 0);
                }

                break;

            case PlatformState.MovingTowardsPoint2:
                if (Time.fixedTime >= _timeAtStateEntry + travelTime)
                {
                    _timeAtStateEntry = Time.fixedTime;
                    _currentPlatformState = PlatformState.WaitingAtPoint2;
                    _rb.MovePosition(_startPosition + relativeEndPosition);
                    _movementPerDeltaTime = new Vector3(0, 0, 0);
                }

                break;

            case PlatformState.WaitingAtPoint1:
                if (Time.fixedTime >= _timeAtStateEntry + waitTime)
                {
                    _timeAtStateEntry = Time.fixedTime;
                    _currentPlatformState = PlatformState.MovingTowardsPoint2;
                    _movementPerDeltaTime = relativeEndPosition / (travelTime / 0.02f);
                }

                break;

            case PlatformState.WaitingAtPoint2:
                if (Time.fixedTime >= _timeAtStateEntry + waitTime)
                {
                    _timeAtStateEntry = Time.fixedTime;
                    _currentPlatformState = PlatformState.MovingTowardsPoint1;
                    _movementPerDeltaTime = (relativeEndPosition / (travelTime / 0.02f)) * -1;
                }

                break;

            default:
                throw new Exception("Current platform state is in impossible state. Blame space rays");
        }
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(transform.position + _movementPerDeltaTime);
    }

    private IEnumerator Blink()
    {
        while (true) // P R O G R A M M I N G.
            // Definitely did not get mad at unity for crashing before realizing i forgot to yield :)
        {
            var status = _light.enabled;
            _light.enabled = !status;

            _renderer.material = !status ? lightOnMaterial : lightOffMaterial;
            yield return new WaitForSeconds(blinkTime);
        }
    }
}