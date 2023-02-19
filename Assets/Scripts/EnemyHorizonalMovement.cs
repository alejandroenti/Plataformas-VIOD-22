using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizonalMovement : MonoBehaviour
{

    public GameObject attack;
    BoxCollider2D attackCollider;

    public SpriteRenderer sr;
    public LinearMovement lm;
    BoxCollider2D coll;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        lm = GetComponent<LinearMovement>();
        coll = GetComponent<BoxCollider2D>();
        attackCollider = attack.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lm.nextPoint == 1)
        {
            sr.flipX = true;
            coll.offset = new Vector2(0.08f, 0);
            attackCollider.offset = new Vector2(-0.2f, 0);
        }
        else
        {
            sr.flipX = false;
            coll.offset = new Vector2(-0.08f, 0);
            attackCollider.offset = new Vector2(0.2f, 0);
        }
    }
}
