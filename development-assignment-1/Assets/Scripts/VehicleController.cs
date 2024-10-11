using UnityEngine;
using UnityEngine.InputSystem;

public class VehicleController : MonoBehaviour
{
    public float hoverHight;
    public int hoverStabilizationSpeed;
    public int speed;
    public Material paintColor;
    public float rotationSpeed;
    public VehicleBodyController vehicleBody;
    public VehicleBarrelController vehicleBarrel;
    public string[] PaintSurfaceBlacklist;
    public string[] OrientationSurfaces;

    private float movementX;
    private float movementY;
    private float movementZ;

    private Vector3 rayHitOrientation;

    // Start is called before the first frame update
    void Start()
    {
        movementX = 0;
        movementY = 0;
        movementZ = 0;
        vehicleBody.SetRotationSpeed(rotationSpeed);
        rayHitOrientation = new Vector3(0, 0, 0);
    }

    void MatchSurfaceOrientation()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        {
            for (int i = 0; i < OrientationSurfaces.Length; i++)
            {
                if (hit.collider.gameObject.CompareTag(OrientationSurfaces[i]))
                {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance,
                        Color.yellow);
                    movementY = (hoverHight - hit.distance) / hoverStabilizationSpeed;
                    rayHitOrientation = hit.normal * 100;
                    break;
                }
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 1000, Color.white);
            PerformEscapeVoidManoeuvres();
        }
    }

    void PerformEscapeVoidManoeuvres()
    {
        movementY = 1; 
        rayHitOrientation = new Vector3(0, 0, 0);
    }

    void OnFire(InputValue fireValue)
    {
        vehicleBarrel.Fire(paintColor, PaintSurfaceBlacklist);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementZ = movementVector.y;
    }

    void OnTurn(InputValue turnValue)
    {
        vehicleBody.TurnVehicle(turnValue);
    }

    void Update()
    {
        MatchSurfaceOrientation();
        
        //movement
        Vector3 movement = new Vector3(movementX, movementY, movementZ);
        transform.position += vehicleBody.transform.TransformDirection(movement * (speed * Time.deltaTime));

        //rotation
        Vector3 transformDirection = new Vector3(
            rayHitOrientation.x,
            rayHitOrientation.y,
            rayHitOrientation.z);
        transform.up = transformDirection;
    }
}