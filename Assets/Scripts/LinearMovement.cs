using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : MonoBehaviour
{

    public List<Transform> points;
    public int nextPoint = 0;
    public float speed = 5;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[nextPoint].position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = points[nextPoint].position - transform.position;
        //float distance = dir.magnitude;
        distance = dir.magnitude;
        dir.Normalize();

        transform.position += dir * speed * Time.deltaTime;

        if (distance < 0.5f) 
        {
            nextPoint++;

            if (nextPoint >= points.Count)
            {
                nextPoint = 0;
            }
        }
    }
}
