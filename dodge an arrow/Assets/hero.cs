using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    private float moveInput;

    Rigidbody2D rb;
    Animator anim;

    private bool facingRight = true;

    int playerObject, collideObject;

    public UIController control;

    public bool Grounded = false;
    public Transform GroundCheck;
    public float GroundRadius = 0.2f;
    public LayerMask whatisground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        playerObject = LayerMask.NameToLayer("Player");
        collideObject = LayerMask.NameToLayer("Collide");

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundRadius, whatisground);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -6.55f, 6.55f);
        if (pos.y == 2.98f)
            pos.y = 2.97f;
        else if (pos.y == -0.9660626f)
            pos.y = -0.9660627f;
        else
            
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.W) && Grounded) {
            jump(); // check for using jump
        }

        if (rb.velocity.y > 0)
        {
            Physics2D.IgnoreLayerCollision(playerObject, collideObject, true);
        }
        else 
        {
            Physics2D.IgnoreLayerCollision(playerObject, collideObject, false);
        }

        if (Input.GetKey (KeyCode.S))
        {
            Physics2D.IgnoreLayerCollision(playerObject, collideObject, true);
        }

       

        if (Input.GetAxis("Horizontal") == 0) {
            anim.SetInteger("heroparameter", 1);
        }
        else
        {
            anim.SetInteger("heroparameter", 2);
        }

        moveInput = Input.GetAxis("Horizontal"); //move
        rb.velocity = new Vector2(moveInput * 5f, rb.velocity.y);

        if (facingRight == false && moveInput > 0) //flip the hero
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }


    void jump()
    {
        rb.AddForce(transform.up * 6.85f, ForceMode2D.Impulse);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "arrow")
        {
            Destroy(gameObject);
            control.gameOverTrue();
        }
    }

}
