using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    [SerializeField]
    private float minVelocity = 10f;
    private Rigidbody rb;

    private Vector3 lastFrameVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Bounce(collision.contacts[0].normal);
    }

    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

        rb.velocity = direction * Mathf.Max(speed, minVelocity);
    }
}
