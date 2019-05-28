using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    public Vector2 speed;
    Vector3 pos;
    public Rigidbody2D rb;
    void Start()
    {   
        keepPosition();
    }

    void FixedUpdate()
    {
        if (rb.position.y < -2)
        {
            transform.position = pos;
            rb.velocity=Vector2.zero;
        }
    }
    void keepPosition()
    {
        pos = transform.position;
    }
}
