using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusMoveS : MonoBehaviour
{
    private Transform player;

    private float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        transform.position += Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed*Time.deltaTime);
    }
}
