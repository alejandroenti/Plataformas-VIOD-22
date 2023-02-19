using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockeableObject : MonoBehaviour
{

    public BoxCollider2D coll;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.hasLevelKey = true;
            Destroy(gameObject);
        }
    }
}
