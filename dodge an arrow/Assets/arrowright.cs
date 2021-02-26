using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowright : MonoBehaviour
{
    private float speed;

    Rigidbody2D rb_arrow;
    // Start is called before the first frame update
    void Start()
    {
        speed = -5f;
        rb_arrow = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb_arrow.velocity = new Vector2(speed, rb_arrow.velocity.y);
    }
}
