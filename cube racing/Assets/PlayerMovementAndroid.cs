using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerMovementAndroid : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] private LayerMask layerMask;
    private bool isMoving = true;
    private Player1Input playerInput;
    private Rigidbody rigidbody;
    private float forwardForce = 2000f;
    public GameObject bullet;
    [SerializeField] private Animator animator;
    private Text text;
    public float damage = 0;
    private bool attackAnimPlay = false;
    private bool isShooting = false;
    private float attackTime = 0.3f;
    [SerializeField] private float startAttackTime;
    [SerializeField] private Transform player;
    private float startTimeOfReturning;
    private float timeOfReturning = 0.3f;
    public bool canThrow = true;
    void Awake()
    {
        playerInput = new Player1Input();

        playerInput.Player1.MovePress.performed += context => HoldedTouch(context);
        playerInput.Player1.MovePress.canceled += context => CanceledTouch(context);
        playerInput.Player1.ThrowPress.performed += context => Throw(context);
        playerInput.Player1.ThrowPress1.performed += context => Throw(context);

    }



    

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

    }

    private void Throw(InputAction.CallbackContext context)
    {
        /*if (!canThrow && !checkThrow)
        {
            return;
        }*/
        if (!attackAnimPlay && !isShooting && canThrow)
        {
            attackAnimPlay = true;
            isShooting = true;
            startAttackTime = Time.time;
            animator.SetBool("IsAttacking", true);
        }
        Debug.Log("throw");
    }
    public void CanThrow(bool flag)
    {
        canThrow = flag;
    }

    private void CanceledTouch(InputAction.CallbackContext context)
    {
        isMoving = false;
    }

    private void HoldedTouch(InputAction.CallbackContext context)
    {
        isMoving = true;
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
    void StartTouch(InputAction.CallbackContext context)
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.touchCount > 0 && isMoving)
        {
            MoveToTouchPosition();
            
        }
        if (rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        player.transform.localPosition = new Vector3(0, 0, 0);
        if (isShooting && ((startAttackTime + attackTime) < Time.time) &&  attackAnimPlay)
        {
            isShooting = false;
            animator.SetBool("IsAttacking", false);
            startTimeOfReturning = Time.time;


            Instantiate(bullet, new Vector3(transform.position.x + 0.3f, transform.position.y + 0.32f, transform.position.z + 1.5f), Quaternion.identity);


        }
        if (Time.time > (startTimeOfReturning + timeOfReturning) && attackAnimPlay && !isShooting)
        {

            attackAnimPlay = false;
        }



    }
    void MoveToTouchPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(playerInput.Player1.MoveTouchPosition.ReadValue<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100f, layerMask))
        {
            if (hit.collider != null && hit.transform.tag == "MovementPlane")
            {
                //Vector3 targetPosition = transform.InverseTransformPoint(hit.point);
                Vector3 targetPosition = hit.point;
                targetPosition.z = transform.position.z;
                targetPosition.y = transform.position.y;
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, 505 * Time.deltaTime);

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(damage);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(damage);
    }
    void Swipe()
    {
        Vector2 delta = Input.GetTouch(0).deltaPosition;
        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
        {
            if(delta.x > 0)
            {
                Debug.Log("move right");
            }
            else
            {
                Debug.Log("move left");
            }
        }
        else
        {
            if(delta.y > 0)
            {
                Debug.Log("move up");
            }
            else
            {
                Debug.Log("move down");
            }
        }
    }
}
