using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Rigidbody for player.
    private Rigidbody rb; 

    // Movement along X and Y axes.
    private float movementX;
    private float movementY;

    // Player speed.
    public float speed = 0; 

    void Start()
    {
        // Get and store the Rigidbody component attached to the player.
        rb = GetComponent<Rigidbody>();
    }
 
    // Imput detected.
    void OnMove(InputValue movementValue)
    {
        // Change value to a Vector2 for movement.
        Vector2 movementVector = movementValue.Get<Vector2>();

        // Stores movement.
        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }

    // FixedUpdate is called once per fixed frame-rate frame.
    private void FixedUpdate() 
    {
        // Creates 3D movement.
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);

        // Force to the Rigidbody of player.
        rb.AddForce(movement * speed); 
    }
}