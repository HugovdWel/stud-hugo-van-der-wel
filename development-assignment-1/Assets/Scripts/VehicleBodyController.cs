using UnityEngine;
using UnityEngine.InputSystem;

public class VehicleBodyController : MonoBehaviour
{
    private int rotation;
    private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetRotationSpeed(float rotationSpeed)
    {
        this.rotationSpeed = rotationSpeed;
    }

    public void TurnVehicle(InputValue turnValue)
    {
        Vector2 turnAxis = turnValue.Get<Vector2>();
        rotation = (int) turnAxis.x;
    }

    void FixedUpdate()
    {
        //rotation left/right
        transform.Rotate(new Vector3(0, rotation * (rotationSpeed * Time.deltaTime), 0));
    }
}