using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacleS : MonoBehaviour
{
    public GameObject ground;
    private bool toRight;

    private void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(toRight)
        {
            transform.position = new Vector3(transform.position.x + 15f*Time.deltaTime, transform.position.y, transform.position.z);
            if(transform.position.x > /*(*//*ground.transform.position.x + ground.transform.localScale.x/2)*/7)
            {
                toRight = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x - 15f*Time.deltaTime, transform.position.y, transform.position.z);
            if (transform.position.x < /*(*//*ground.transform.position.x - ground.transform.localScale.x / 2)*/-7)
            {
                toRight = true;
            }
        }
    }
}
