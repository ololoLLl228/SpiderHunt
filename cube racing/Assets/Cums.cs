using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cums : MonoBehaviour
{
    [SerializeField] private GameObject explosionEffect;
    // Start is called before the first frame update
    private int Speed = 20;
    private float bulletDestroyTime = 3;
    private float startBulletDestroyTime;
    private Vector3 lastPos;
    private PlayerMovementAndroid player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementAndroid>();

        lastPos = transform.position;
    }
    void Start()
    {
        transform.rotation = Quaternion.Euler(180, 0, 0);
        startBulletDestroyTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        //RaycastHit hit;
        /*if (Physics.Linecast(lastPos, transform.position, out hit))
        {
            
            

            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }*/
        lastPos = transform.position;
        if (Time.time > startBulletDestroyTime + bulletDestroyTime)
        {
            Destroy(gameObject);
        }

    }
    
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}


