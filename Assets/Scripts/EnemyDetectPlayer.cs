using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class EnemyDetectPlayer : MonoBehaviour
{

    public float fieldOfView;
    public float attackRange = 0.2f;
    public float animationTimer = 2;
    public LayerMask mask;
    public List<Vector3> rays;
    public GameObject attack;
    EnemyHorizonalMovement ehm;
    EnemyController ec;
    EnemySwordAttack esa;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        ehm = GetComponent<EnemyHorizonalMovement>();
        ec = GetComponent<EnemyController>();
        esa = attack.GetComponent<EnemySwordAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ehm.lm.nextPoint == 1)
        {
            dir = transform.right * -1;
        }
        else
        {
            dir = transform.right;
        }

        Debug.DrawRay(transform.position, dir * fieldOfView, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, fieldOfView, mask);

        if (hit.collider != null)
        {
            Debug.DrawRay(transform.position, dir * hit.distance, Color.cyan);

            if (hit.distance - fieldOfView <= attackRange && !ec.isAttacking)
            {
                StartCoroutine(IsAttacking_Corutine());
            }
        }
    }

    public IEnumerator IsAttacking_Corutine()
    {
        ec.isAttacking = true;
        yield return new WaitForSeconds(animationTimer);
        ec.isAttacking = false;
    }
}
