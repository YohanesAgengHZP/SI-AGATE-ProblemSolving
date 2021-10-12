using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousemovement : MonoBehaviour
{
    public float maxMoveSpeed = 10;
    public float smoothTime = 0.3f;
    public Scorecount score;

    Vector2 currentVelocity;

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "kotakspawn")
        {
            score.IncrementScore();
            Destroy(collision.gameObject);
        }
    }

}
