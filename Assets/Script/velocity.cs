using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour
{
    private Rigidbody2D rb;
    public float y = 0.0f;
    public float x = 0.0f;

    private void Awake()
    {
        x = 3.0f;
        y = 5.0f;
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(x, y);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wallx")
        {
            x = -x;
        }

            if (collision.gameObject.tag == "wally")
            {
                y = -y;
            }
    }
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
