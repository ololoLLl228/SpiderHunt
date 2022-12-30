using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody rigidbody;
    private float forwardForce = 2000f;
    private bool turning;
    private bool isInAir;
    private bool isDown;
    private BoxCollider boxCollider;
    [SerializeField]private float maxDistance = 10f;
    private bool nextHit;
    public GameObject bullet;
    public Animator animator;
    private float startJumpingTime;
    [SerializeField]private float timeOfJumpingUp;
    [SerializeField] private GameObject Player;
    [SerializeField]private float attackTime = 0.8f;
    [SerializeField]private float startAttackTime;
    private bool attackAnimPlay = false;
    private bool isShooting = false;
    [SerializeField] private float startTimeOfReturning;
    [SerializeField] private float timeOfReturning = 0.05f;
    public float damage = 0;

    // Start is called before the first frame update
    private void Start()
    {

        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(0, 0, forwardForce*Time.deltaTime);
        if((!IsGrounded()) && isDown)
        {
            isDown = false;
            animator.SetBool("IsJumping", true);
        }
        if(Input.GetKey("d"))
        {
            //transform.position = new Vector3(transform.position.x + 0.15f , transform.position.y, transform.position.z);
            rigidbody.AddForce(50*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a"))
        {

            //transform.position = new Vector3(transform.position.x - 0.15f , transform.position.y, transform.position.z);
            rigidbody.AddForce(-50*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKeyDown("space") && IsGrounded() && isDown)
        {
            isDown = false;
            animator.SetBool("IsJumping", true);
            rigidbody.AddForce(0, 10, 0, ForceMode.VelocityChange);
            startJumpingTime = Time.time;
            Player.transform.rotation = Quaternion.Euler(0, 0, 0);
            Player.transform.localPosition = new Vector3(0, 0, 0);

            
        }
        
        
        if (Input.GetKeyDown("s") && !isInAir && !IsGrounded())
        {
            rigidbody.AddForce(0, -15, 0, ForceMode.VelocityChange);
            isInAir = true;
            
        }
        if(rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if(Input.GetKeyDown(KeyCode.Mouse0) && !attackAnimPlay && (!isShooting))
        {
            if(!attackAnimPlay && (!isShooting))
            {
                attackAnimPlay = true;
                isShooting = true;
                startAttackTime = Time.time;
                
                animator.SetBool("IsAttacking", true);
                Player.transform.rotation = Quaternion.Euler(0, 0, 0);
                Player.transform.localPosition = new Vector3(0, 0, 0);
                
            }
            
            
        }
        /*if((startAttackTime/1.1f + attackTime) < Time.time && isShooting)
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), Quaternion.identity);
            isShooting = false;
        }*/

        if(((startAttackTime + attackTime) < Time.time) && isShooting && attackAnimPlay)
        {
            isShooting = false;
            animator.SetBool("IsAttacking", false);
            startTimeOfReturning = Time.time;
            
            
            Instantiate(bullet, new Vector3(transform.position.x + 0.3f, transform.position.y + 0.32f, transform.position.z + 1.5f), Quaternion.identity);
            
            
        }
        if(Time.time > (startTimeOfReturning + timeOfReturning) && attackAnimPlay && !isShooting)
        {
            
            attackAnimPlay = false;
        }
        Player.transform.rotation = Quaternion.Euler(0, 0, 0);
        Player.transform.localPosition = new Vector3(0, 0, 0);


    }

    private bool IsGrounded()
    {
        float extraHeight = .01F;
        RaycastHit hit;
        bool hits = false;
        hits = Physics.BoxCast(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), 
            transform.localScale/2, Vector3.down, out hit, transform.rotation, transform.localScale.y/2 + extraHeight);
        if(hits)
        {
            
            nextHit = true;
        }

        return hit.collider != null || hits;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            isInAir = false;
            
            isDown = true;
            
            animator.SetBool("IsMoving", false);
            animator.SetBool("IsJumping", false);
            
            rigidbody.AddForce(0, 0, 500);
            
            Player.transform.rotation = Quaternion.Euler(0, 0, 0);
            Player.transform.localPosition = new Vector3(0, 0, 0);
        }
      
    }
    void OnDrawGizmos()
    {
        
        RaycastHit hit;
        bool isHit = Physics.BoxCast(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), 
            transform.localScale / 2, Vector3.down, out hit, transform.rotation, transform.localScale.y/2 + maxDistance);
        if(isHit)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Vector3.down*hit.distance);
            Gizmos.DrawWireCube(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z) + Vector3.down*hit.distance, transform.localScale);
        }
        else
        {
            Gizmos.color = Color.green;
            Gizmos.DrawRay(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Vector3.down * maxDistance);
        }

    }
}
