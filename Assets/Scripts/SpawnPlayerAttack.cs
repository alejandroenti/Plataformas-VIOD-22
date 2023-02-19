using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerAttack : MonoBehaviour
{

    public bool isAttacking = false;
    public float attackCoolDown = 0.5f;
    public float colliderOffset = 0.52f;

    public GameObject attack;
    BoxCollider2D attackCollider;
    HorizontalMovement direction;
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        attackCollider = attack.GetComponent<BoxCollider2D>();
        source = attackCollider.GetComponent<AudioSource>();
        direction = GetComponent<HorizontalMovement>();
    }

    // Update is called once per frame
    void Update()
    {

        if (direction.dir == HorizontalMovement.Directions.LEFT)
        {
            attack.transform.position = transform.position - new Vector3(colliderOffset, 0, 0);
        }
        else
        {
            attack.transform.position = transform.position + new Vector3(colliderOffset, 0, 0);
        }

        if (Input.GetButtonDown("Attack") && !attackCollider.enabled) {

            attackCollider.enabled = true;
            isAttacking = true;
            source.Play();

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
