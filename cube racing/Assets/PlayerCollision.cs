using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript movement;
    public Animator animator;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle" || collision.collider.tag == "Monster" || collision.collider.tag == "Boss")
        {

            GetComponent<PlayerMovementAndroid>().enabled = false;
            animator.SetBool("IsDying", true);
            FindObjectOfType<GameManager>().EndGame();

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle" || other.tag == "Monster" || other.tag == "Boss")
        {
            GetComponent<PlayerMovementAndroid>().enabled = false;
            animator.SetBool("IsDying", true);
            FindObjectOfType<GameManager>().EndGame();
        }
        else if(other.tag == "End")
        {
            GetComponent<PlayerMovementAndroid>().enabled = false;
        }
        
    }
}
