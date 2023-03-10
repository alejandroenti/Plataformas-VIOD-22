using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{

    public float speed = 5;
    public SpriteRenderer sr;
    public CapsuleCollider2D coll;
    public Animator anim;
    public GroundDetector ground;
    public Jump jump;
    public SpawnPlayerAttack pAttack;

    public enum Directions { RIGHT, LEFT };
    public Directions dir;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();  
        coll = GetComponent<CapsuleCollider2D>();
        anim = GetComponent<Animator>();
        ground = GetComponent<GroundDetector>();
        jump = GetComponent<Jump>();
        pAttack = GetComponent<SpawnPlayerAttack>();
        dir = Directions.RIGHT;
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal * speed * Time.fixedDeltaTime, 0, 0);

        if (horizontal > 0)
        {
            sr.flipX = false;
            coll.offset = new Vector2(-0.25f, 0);
            dir= Directions.RIGHT;

        }
        if (horizontal < 0) 
        {
            sr.flipX = true;
            coll.offset = new Vector2(0.25f, 0);
            dir = Directions.LEFT;
        }
        anim.SetBool("isMoving", horizontal != 0);
        anim.SetBool("isGrounded", ground.grounded);
        anim.SetBool("isJumping", !jump.canJump);
        anim.SetBool("isAttacking", pAttack.isAttacking);
        anim.SetBool("isAlive", GameManager.instance.lifes > 0);
    }
}
