using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFromGroundS : MonoBehaviour
{
    private bool toDown;

    private void Start()
    {
        toDown = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toDown)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y + 1f * Time.deltaTime, transform.position.z);
            
            if (transform.position.y > transform.localScale.y)
            {
                toDown = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x , transform.position.y - 1f * Time.deltaTime, transform.position.z);
            
            if (transform.position.y < -transform.localScale.y)
            {
                toDown = true;
            }
        }
    }
}
