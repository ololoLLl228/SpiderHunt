using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x , (player.position.y + 19), (player.position.z - 26) );
        transform.rotation = Quaternion.Euler(20, 0, 0);
    }
}
