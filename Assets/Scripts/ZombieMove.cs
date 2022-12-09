using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb2d;
    public SpriteRenderer sprite;

    public float jumpForce;
    private bool jump;
    private bool grounded;
    public GameObject groundCheck;
    public LayerMask whatisGround;

    private Animator anim;

    void Start()
    {
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(jump == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jump = true;
            }
        }
    }

    void FixedUpdate()
    {
        grounded = false;
        grounded = Physics2D.Linecast(transform.position, groundCheck.transform.position, whatisGround);

        if(grounded && jump)
        {
            grounded = false;
            rb2d.AddForce(new Vector2(0f, jumpForce));
        }

        jump = false;

        float horizontal = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);

        if (horizontal > 0 || horizontal < 0) anim.SetInteger("states", 1);
        if (horizontal == 0) anim.SetInteger("states", 0);

        if (horizontal > 0) sprite.flipX = false;
        if (horizontal < 0) sprite.flipX = true;

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Goblin"))
        {
            Dead();
        }
    }
    private void Dead()
    {
        anim.SetBool("Dead",true);
    }
}
