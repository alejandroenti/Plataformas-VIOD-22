using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemySwordAttack : MonoBehaviour
{

    public float attackCoolDown = 2;

    public GameObject attack;
    EnemyController ec;
    BoxCollider2D attackCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        ec = GetComponent<EnemyController>();
        attackCollider = attack.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ec.isAttacking && attackCoolDown == 2) {
            attackCollider.enabled = true;
        }

        if (attackCollider.enabled && attackCoolDown > 0)
        {
            attackCoolDown -= Time.deltaTime;
        }
        else
        {
            attackCollider.enabled = false;
            attackCoolDown = 2;
        }
    }
}
