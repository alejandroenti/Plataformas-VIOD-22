using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedObject : MonoBehaviour
{

    BoxCollider2D coll;
    PlaySound ps;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
        ps = GetComponent<PlaySound>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GameManager.instance.hasLevelKey)
        {
            coll.enabled = false;
            GameManager.instance.levelPassed = true;
            ps.Play();
        }
    }
}
