using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    public Animator anim;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxcollider2d;
    public int jumpForce ;
    public float gravity;
    bool IsDucking = false;
    bool JustDucked = true;

    public float smashDown;

    SpriteRenderer sprite;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
        boxcollider2d = gameObject.GetComponent<BoxCollider2D>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {   
        if(IsGrounded() == true)
        {
            anim.SetBool("IsJumping", false);
        }
        
        if (IsGrounded() == true && Input.GetKey(KeyCode.DownArrow))
        {
            sprite.color = new Color(256,0,0);
            JustDucked = true;
            Duck();
        } 
        else if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            IsDucking = false;
            sprite.color = new Color(256,256,256);
        }

        if (IsGrounded() && JustDucked == true && IsDucking ==false && (Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.UpArrow) ))
        {
            rigidbody2d.velocity = Vector2.up * jumpForce;
            JustDucked = false;
            anim.SetBool("IsJumping", true);
        }

        if (IsGrounded() && JustDucked == false && IsDucking ==false && (Input.GetKey(KeyCode.Space)||Input.GetKey(KeyCode.UpArrow) ))
        {
            rigidbody2d.velocity = Vector2.up * jumpForce;
            anim.SetBool("IsJumping", true);
        }

        if (Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.UpArrow))
        {
             rigidbody2d.velocity = rigidbody2d.velocity * gravity;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rigidbody2d.velocity = Vector2.down * smashDown;
        }


    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxcollider2d.bounds.center, boxcollider2d.bounds.size ,0f, Vector2.down, .1f, platformLayerMask);
        //Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }

    private void Duck()
    {
        IsDucking = true;
    }
}
