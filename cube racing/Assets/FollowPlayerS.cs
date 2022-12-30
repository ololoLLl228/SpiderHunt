using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerS : MonoBehaviour
{
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z);
    }
}
