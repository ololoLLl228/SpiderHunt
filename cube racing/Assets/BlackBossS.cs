using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBossS :MonoBehaviour
{
    // Start is called before the first frame update
    private float dyingStartTime;
    private float dyingTime = 4f;
    private bool beginDying = false;
    private Animator animator;
    bool isAttack;


    void Start()
    {

        gameObject.SetActive(true);
        animator = GetComponent<Animator>();
        animator.SetFloat("AttackIdle", 1);
        //animator.SetBool("isAlive", false);
    }
    private void Update()
    {
        if (animator.GetBool("isDead") == true && !beginDying)
        {
            dyingStartTime = Time.time;
            beginDying = true;
            GetComponent<BoxCollider>().enabled = false;

        }
        if ((Time.time >= dyingStartTime + dyingTime) && beginDying == true)
        {

            gameObject.SetActive(false);
            //animator.SetBool("isAlive", true);

        }
        if (isAttack)
        {
            animator.SetFloat("AttackIdle", 1);
        }
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            animator.SetFloat("AttackIdle", 0);
            Debug.Log("spider collision");

        }
    }
    private void Respawn()
    {

    }
}
