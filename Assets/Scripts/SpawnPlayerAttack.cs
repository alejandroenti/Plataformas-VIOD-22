using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerAttack : MonoBehaviour
{

    public bool isAttacking = false;
    public float attackCoolDown = 0.5f;

    public GameObject attack;
    BoxCollider2D attackCollider;

    // Start is called before the first frame update
    void Start()
    {
        attackCollider = attack.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Attack") && !attackCollider.enabled) {

            attackCollider.enabled = true;
            isAttacking = true;

        }

        if (attackCollider.enabled && attackCoolDown > 0)
        {
            attackCoolDown -= Time.deltaTime;
        }
        else
        {
            attackCollider.enabled = false;
            isAttacking = false;
            attackCoolDown = 0.5f;
        }
    }
}
