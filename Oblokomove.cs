using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oblokomove : MonoBehaviour
{
    private float speed;
    Rigidbody2D rb;

    void Start()
    {
        speed = Random.Range(1, 3);
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(-1, 0) * speed;
    }
}
