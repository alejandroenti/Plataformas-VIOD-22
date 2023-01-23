using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{

    public float speed = 5;
    public SpriteRenderer sr;
    public Animator anim;
    public GroundDetector ground;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();  
        anim = GetComponent<Animator>();
        ground = GetComponent<GroundDetector>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal * speed * Time.fixedDeltaTime, 0, 0);

        if (horizontal > 0)
        {
            sr.flipX = false;
        }
        if (horizontal < 0) 
        {
            sr.flipX = true;
        }
        anim.SetBool("Moving", horizontal != 0);
        anim.SetBool("Grounded", ground.grounded);
    }
}
