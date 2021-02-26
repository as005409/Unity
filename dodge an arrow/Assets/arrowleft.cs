using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowleft : MonoBehaviour
{
    private float speed;

    Rigidbody2D rb_arrow;
    int rightObject, leftObject;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        rb_arrow = GetComponent<Rigidbody2D>();
        rightObject = LayerMask.NameToLayer("Arrowright");
        leftObject = LayerMask.NameToLayer("Arrowleft");
    }

    // Update is called once per frame
    void Update()
    {
        rb_arrow.velocity = new Vector2(speed, rb_arrow.velocity.y);

        Physics2D.IgnoreLayerCollision(rightObject, leftObject, true);
               
    }


}