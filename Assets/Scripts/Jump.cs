using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jump_force;
    public float gravityScale;
    public float fallingGravityScale;

    Rigidbody2D rb;

    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        gravityScale = 2.2f;
        fallingGravityScale = 3.0f;
        rb = GetComponent<Rigidbody2D>();
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(Vector2.up * jump_force, ForceMode2D.Impulse);
            canJump= false;
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
