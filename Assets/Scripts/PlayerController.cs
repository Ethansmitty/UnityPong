using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;
    public float speed = 10.0f;
    public float boundY = 3f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        var vel = rb.velocity;
        if (Input.GetKey(upKey))
        {
            vel.y = speed;
        }
        else if (Input.GetKey(downKey))
        {
            vel.y = -speed;
        }
        else
        {
            vel.y = 0;
        }
        rb.velocity = vel;

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }

}
