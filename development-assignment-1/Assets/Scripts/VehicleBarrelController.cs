using UnityEngine;

public class VehicleBarrelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Fire(Material paintColor, string[] PaintSurfaceBlacklist)
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000,
            Color.red, 3);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            bool objectBlacklisted = false;
            for (int i = 0; i < PaintSurfaceBlacklist.Length; i++)
            {
                if (hit.transform.CompareTag(PaintSurfaceBlacklist[i]))
                {
                    objectBlacklisted = true;
                    break;
                }
            }

            if (objectBlacklisted) return;
            
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance,
                Color.blue, 3);
            hit.transform.gameObject.GetComponent<Renderer>().material = paintColor;

        }
    }
}