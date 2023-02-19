using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizonalMovement : MonoBehaviour
{

    public SpriteRenderer sr;
    LinearMovement lm;
    BoxCollider2D coll;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        lm = GetComponent<LinearMovement>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lm.nextPoint == 1)
        {
            sr.flipX = true;
            coll.offset = new Vector2(0.08f, 0);
        }
        else
        {
            sr.flipX = false;
            coll.offset = new Vector2(-0.08f, 0);
        }
    }
}
