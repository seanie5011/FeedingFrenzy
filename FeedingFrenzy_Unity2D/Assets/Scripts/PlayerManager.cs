using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // collect player components
    InputManager inputManager;
    PlayerLocomotion playerLocomotion;

    // on script instantiation
    private void Awake()
    {
        // instantiate player components
        inputManager = GetComponent<InputManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
    }

    // called every frame
    void Update()
    {
        
    }

    // called every fixed physics frame
    private void FixedUpdate()
    {
        // use input managers values for locomotion
        playerLocomotion.HandleAllLocomotion(inputManager.movementInput, false);
    }
}
