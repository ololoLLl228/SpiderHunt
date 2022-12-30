using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1InputSystem : MonoBehaviour
{
    private Rigidbody playerRigidBody;
    private Player1Input playerInput;
    private float speed = 0.5f;
   private void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        playerInput = new Player1Input();

    }
    private void FixedUpdate()
    {
        
        Vector2 inputVector = playerInput.Player1.Move.ReadValue<Vector2>();
        playerRigidBody.AddForce(new Vector3(inputVector.x, 0, 0)*speed, ForceMode.VelocityChange);
        

        
    }
    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
    public void MoveLeft(InputAction.CallbackContext context)
    {
        Debug.Log("Move left " + context.phase);
        if (context.started)
        {
            playerRigidBody.AddForce(Vector3.left, ForceMode.VelocityChange);
        }
    }
    public void MoveRight(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            playerRigidBody.AddForce(Vector3.right, ForceMode.VelocityChange);
        }
    }
    public void Throw()
    {
        Debug.Log("Throw");
    }
}
