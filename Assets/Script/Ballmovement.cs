using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmovement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    Vector2 currentVelocity;

    public float maxMoveSpeed = 10f;
    public float smoothTime = 0.3f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    { 
        // gerakan player menggunakan WASD ataupun arrowkey
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        // gerakan bola mengikuti mouse, menggunakan smoothdamp sehingga gerakan lebih halus
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed);
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * maxMoveSpeed, vertical * maxMoveSpeed);
    }
}
