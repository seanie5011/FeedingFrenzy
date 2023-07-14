using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    // collect player components
    InputManager inputManager;
    Rigidbody2D playerRigidbody;

    // movement parameters
    [Header("Movement")]
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private float sprintSpeed = 7f;

    // on script instantiation
    private void Awake()
    {
        // instantiate player components
        inputManager = GetComponent<InputManager>();
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // calls all locomotion handlers as needed
    public void HandleAllLocomotion(Vector2 movementInput, bool isSprinting)
    {
        // movement
        HandleMovement(movementInput, isSprinting);
    }

    // sets the players movement based on a vector2 input
    private void HandleMovement(Vector2 movementInput, bool isSprinting)
    {
        // the speed we will move player at
        float moveSpeed;

        // if we are sprinting
        if (isSprinting)
        {
            // move at sprint speed
            moveSpeed = sprintSpeed;
        }
        // not sprinting
        else
        {
            // move at walk speed
            moveSpeed = walkSpeed;
        }

        // set rigidbody velocity based on input and speed
        playerRigidbody.velocity = movementInput * moveSpeed;
    }
}
