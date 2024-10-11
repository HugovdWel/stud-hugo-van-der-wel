using System.Collections;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float rotationSpeed;
    public float moveSpeed;
    public float lifetime;
    public float pushBackForce;

    public Rigidbody rb;


    private void Awake()
    {
        StartCoroutine(DestroyGameObjectWhenLifetimeHasPassed());
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        transform.eulerAngles += new Vector3(0, rotationSpeed, rotationSpeed);
    }

    private IEnumerator DestroyGameObjectWhenLifetimeHasPassed()
    {
        var startTime = Time.time;
        while (startTime > Time.time - lifetime)
        {
            yield return null;
        }

        Destroy(gameObject);
    }
}