using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jump_force;
    public float gravityScale;
    public float fallingGravityScale;

    Rigidbody2D rb;

    private bool canJump;
    GroundDetector groundDetector;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groundDetector = GetComponent<GroundDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        canJump = groundDetector.grounded;

        if (Input.GetButtonDown("Jump") && canJump)
        {
            rb.AddForce(Vector2.up * jump_force, ForceMode2D.Impulse);
            canJump = false;
            rb.gravityScale = gravityScale;
        }

        if (rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }

        if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
            canJump = true;
        }
    }
}
