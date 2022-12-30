using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletS : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject explosionEffect;
    public int Speed;
    Vector3 lastPos;
    private float bulletDestroyTime = 1;
    private float startBulletDestroyTime;
    private PlayerMovementAndroid player;
    private float damage;
 
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementAndroid>();
        damage = player.damage;
        Debug.Log("bullet damage" + damage);
        lastPos = transform.position;
        startBulletDestroyTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        RaycastHit hit;
        if (Physics.Linecast(lastPos, transform.position, out hit))
        {
            if (hit.transform.tag == "Monster")
            {
                Animator monsterAnimator;
                monsterAnimator = hit.transform.GetComponent<Animator>();

                monsterAnimator.SetBool("isDead", true);

            }
            if (hit.transform.tag == "Boss")
            {
                Debug.Log("Boss is hitted with" + damage);
                HealthPower health = hit.transform.GetComponent<HealthPower>();
                health.TakeHit(damage);
            }

            if (hit.transform.gameObject.layer != LayerMask.NameToLayer("Cum"))
            {

                Instantiate(explosionEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
        lastPos = transform.position;
        if(Time.time > startBulletDestroyTime + bulletDestroyTime)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision bullet");
        if(collision.transform.tag == "Monster")
        {
            Animator monsterAnimator = collision.transform.GetComponent<Animator>();
            monsterAnimator.SetBool("isDead", true);
        }
        if(collision.transform.tag == "Boss")
        {
            Debug.Log("Boss is hitted with" + damage);
            HealthPower health = collision.transform.GetComponent<HealthPower>();
            health.TakeHit(damage);
        }
        Destroy(gameObject);
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Monster")
        {
            Animator monsterAnimator = other.GetComponent<Animator>();
            monsterAnimator.SetBool("isDead", true);
        }
        if (other.tag == "Boss")
        {
            Debug.Log("Boss is hitted" + damage);
            HealthPower health = other.GetComponent<HealthPower>();
            health.TakeHit(damage);
        }
        if(other.gameObject.layer != LayerMask.NameToLayer("Cum"))
        {

            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
