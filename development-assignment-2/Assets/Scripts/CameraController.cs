using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float cameraAngle;
    public float cameraHeight;

    public bool enableTest;

    private void LateUpdate()
    {
        var cameraOrientation = player.transform.forward;
        cameraOrientation.y = cameraAngle;

        var cameraPositionOffset = new Vector3(0, cameraHeight, 0);

        var playerPosition = player.transform.position;
        var ownTransform = transform;

        //rotation
        ownTransform.forward = playerPosition - (playerPosition - cameraOrientation);

        //position
        ownTransform.position = (playerPosition + cameraPositionOffset);
    }
}