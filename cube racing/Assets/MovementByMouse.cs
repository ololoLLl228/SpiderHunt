using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementByMouse : MonoBehaviour
{
    private Transform player;
    private float speed = 30f;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void Update()
    {
        Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        //target.z = transform.position.z;
        target.y = transform.position.y;
        target.x = transform.position.x;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
