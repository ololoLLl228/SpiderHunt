using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackSpiderS : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject cum;
    private float dyingStartTime;
    [SerializeField] private float dyingTime = 4f;
    private bool beginDying = false;
    public Animator animator;
    bool isAttack;
    IEnumerator coroutine;
    [SerializeField] private GameObject bonus;

    
    void Start()
    {

        coroutine = WebShoot();
        gameObject.SetActive(true);
        animator = GetComponent<Animator>();
        animator.SetFloat("AttackIdle", 1);
        StartCoroutine(routine: coroutine);
        //animator.SetBool("isAlive", false);
    }
    private void Update()
    {
        if(animator.GetBool("isDead") == true && !beginDying)
        {
            dyingStartTime = Time.time;
            beginDying = true;
            GetComponent<BoxCollider>().enabled = false;
            StopCoroutine(coroutine);
            GiveBonus();


        }
        if ((Time.time >= dyingStartTime + dyingTime) && beginDying == true)
        {

            gameObject.SetActive(false);
            //animator.SetBool("isAlive", true);
            
        }
        if(isAttack)
        {
            animator.SetFloat("AttackIdle", 1);
        }
        

    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            animator.SetFloat("AttackIdle", 0);


        }
    }
    
    private IEnumerator WebShoot()
    {
        while(true)
        {
            animator.SetFloat("AttackIdle", 0);
            isAttack = true;
            Instantiate(cum, new Vector3(transform.position.x, transform.position.y + 0.7f, transform.position.z - 2f), Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
    private void GiveBonus()
    {
        Instantiate(bonus, transform.position, Quaternion.identity);
    }
}
