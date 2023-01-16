using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    public bool grounded;

    public float groundDistance = 1.5f;
    public LayerMask groundMask;

    public List<Vector3> rays;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int count = 0;
        
        for (int i = 0; i < rays.Count; i++)
        {

            Debug.DrawRay(transform.position + rays[i], transform.up * -1 * groundDistance, Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position + rays[i], transform.up * -1, groundDistance, groundMask);

            if (hit.collider != null)
            {
                count++;
                Debug.DrawRay(transform.position + rays[i], transform.up * -1 * hit.distance, Color.green);
            }

            if (count > 0)
            {
                grounded = true;
            }
            else 
            {
                grounded = false;
            }
        }
    }
}
