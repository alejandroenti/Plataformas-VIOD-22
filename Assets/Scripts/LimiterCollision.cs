using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiterCollision : MonoBehaviour
{

    CapsuleCollider2D coll;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<CapsuleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Limiter")
        {
            GameManager.instance.lifes = 0;
        }
    }
}
