using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // controls from input system
    PlayerControls playerControls;

    // player movement
    public Vector2 movementInput;  // accessed in PlayerLocomotion

    // when the input manager is enabled
    private void OnEnable()
    {
        // if we dont have player controls yet
        if (playerControls == null)
        {
            // make them
            playerControls = new PlayerControls();

            // collect Vector2 from input performed
            playerControls.PlayerMovement.Move.performed += (i) => { movementInput = i.ReadValue<Vector2>(); };
        }

        // enable player controls
        playerControls.Enable();
    }

    // when the input manager is disabled
    private void OnDisable()
    {
        // disable player controls
        playerControls.Disable();
    }
}
