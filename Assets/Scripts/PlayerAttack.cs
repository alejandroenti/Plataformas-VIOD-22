using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    BoxCollider2D coll;
    GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemy = collision.gameObject;
            enemy.GetComponent<EnemyController>().StartCoroutine(enemy.GetComponent<EnemyController>().Hit_Corutine());
        }
    }
}