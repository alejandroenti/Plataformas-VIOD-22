using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollower : MonoBehaviour
{

    public Transform target;
    public float speed;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 dir = target.transform.position - transform.position;
        float distance = dir.magnitude;

        if (distance > 4f)
        {
            speed = 10;
        }

        transform.position = Vector3.Lerp(transform.position, target.position + offset, speed * Time.deltaTime);
    }
}
