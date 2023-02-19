using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public int lifes = 3;
    public bool hit = false;
    public bool isAlive = true;
    public bool isAttacking = false;
    public float animationTimer = 0.5f;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lifes <= 0)
        {
            StartCoroutine(Death_Corutine());
        }

        anim.SetBool("isMoving", true);
        anim.SetBool("hit", hit);
        anim.SetBool("isAlive", isAlive);
        anim.SetBool("isAttacking", isAttacking);
    }

    public void Muerte()
    {

    }

    public IEnumerator Hit_Corutine()
    {
        lifes--;
        hit = true;
        yield return new WaitForSeconds(animationTimer);
        hit = false;
    }

    public IEnumerator Death_Corutine()
    {
        isAlive = false;
        yield return new WaitForSeconds(animationTimer * 2);
        Destroy(gameObject);
    }
}