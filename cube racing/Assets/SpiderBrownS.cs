using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBrownS : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isJumpRight;
    private bool isJumpLeft;
    private Vector3 startPosition;
    private Vector3 endPosition;
    private Vector3 startRelPosition;
    private Vector3 endRelPosition;
    private Vector3 centerPosition;
    [SerializeField] private Transform startPositionObject;
    [SerializeField] private Transform endPositionObject;
    [SerializeField]private float elapsedTime;
    private bool moveRight = true;
    private bool moveLeft;
    
    private float movementDuration = 2f;
    private float dyingStartTime;
    [SerializeField] private float dyingTime = 4f;
    private bool beginDying = false;
    public Animator animator;
    bool isAttack;
    [SerializeField]private float percantageComplete;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private GameObject bonus;

    void Start()
    {
        elapsedTime = Random.Range(0, 2);
        startPosition = startPositionObject.position;
        endPosition = endPositionObject.position;
        GetCenter();
        gameObject.SetActive(true);
        animator = GetComponent<Animator>();
        animator.SetFloat("AttackIdle", 1);
        animator.SetBool("isAlive", false);
    }
    private void Update()
    {

        if (animator.GetBool("isDead") == true && !beginDying)
        {
            dyingStartTime = Time.time;
            beginDying = true;
            GetComponent<BoxCollider>().enabled = false;
            GiveBonus();

        }
        if ((Time.time >= dyingStartTime + dyingTime) && beginDying == true)
        {

            gameObject.SetActive(false);
            //animator.SetBool("isAlive", true);

        }
        
        if(!beginDying && !isAttack)
        {
            SlerpCalculation();
            LerpMovement();
        }
        

    }
    private void SlerpCalculation()
    {
        if (percantageComplete < 0 && !moveLeft)
        {


            moveRight = false;
            moveLeft = true;
            elapsedTime = 0;
        }
        if (percantageComplete < 0.1 && !isJumpRight)
        {
            animator.SetBool("IsJumpLeft", false);
            animator.SetBool("IsJumpRight", true);
            isJumpRight = true;
            isJumpLeft = false;
        }
        if (percantageComplete > 0.1 && animator.GetBool("IsJumpRight"))
        {
            animator.SetBool("IsJumpRight", false);
        }
        if (percantageComplete < 0.96 && animator.GetBool("IsJumpLeft"))
        {
            animator.SetBool("IsJumpLeft", false);
        }
        if (percantageComplete > 0.9 && !isJumpLeft)
        {
            animator.SetBool("IsJumpRight", false);
            animator.SetBool("IsJumpLeft", true);
            isJumpLeft = true;
            isJumpRight = false;
        }
        if (percantageComplete > 1 && !moveRight)
        {
            moveLeft = false;


            moveRight = true;
            elapsedTime = movementDuration;
        }
    }
    private void GetCenter()
    {
        centerPosition = (startPosition + endPosition) * 0.5f;
        centerPosition -= new Vector3(0, 7, 0);
        startRelPosition = startPosition - centerPosition;
        endRelPosition = endPosition - centerPosition;


    }
    private void LerpMovement()
    {
        if (moveLeft)
        {
            LerpMovementLeft();
        }
        if (moveRight)
        {
            LerpMovementRight();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            animator.SetFloat("AttackIdle", 0);
            isAttack = true;

        }
    }
    private void LerpMovementLeft()
    {

        elapsedTime += Time.deltaTime;
        percantageComplete = elapsedTime / movementDuration;
        transform.position = Vector3.Slerp(startRelPosition, endRelPosition, curve.Evaluate(percantageComplete));
        transform.position += centerPosition;
    }
    private void LerpMovementRight()
    {
        
        elapsedTime -= Time.deltaTime;
        percantageComplete = elapsedTime / movementDuration;
        transform.position = Vector3.Slerp(startRelPosition, endRelPosition, curve.Evaluate(percantageComplete));
        transform.position += centerPosition;
    }
    private void GiveBonus()
    {
        Instantiate(bonus, transform.position, Quaternion.identity);
    }
}
