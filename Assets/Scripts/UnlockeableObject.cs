using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class UnlockeableObject : MonoBehaviour
{

    public BoxCollider2D coll;
    public float timerSetUp = 0.3f;
    public float speed;
    public Vector3 offset = new Vector3(0, 0.00002f, 0);

    PlaySound ps;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
        ps = GetComponent<PlaySound>();
        float timer = timerSetUp;
    }

    private void Update()
    {
        
        timer -= Time.deltaTime * speed;
        transform.position += offset;

        if (timer <= 0)
        {
            timer = timerSetUp;
            offset *= -1;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.hasLevelKey = true;
            ps.Play();
            Destroy(gameObject, 0.3f);
        }
    }
}
