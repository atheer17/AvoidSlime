using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public Animator anim; // Changed 'Animation' to 'Animator'

    void Start()
    {
        // Initialization code (if needed)
    }

    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        // Calculate movement vector
        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement);
        Rigidbody.AddForce(movement * 5f); // Apply force to Rigidbody

        // Rotate character to face movement direction
        if (movement != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            Rigidbody.MoveRotation(targetRotation);
        }

        // Jump when Space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(Vector3.up * 15f, ForceMode.Impulse);
        }

        // Set animation parameters
        anim.SetFloat("horizontalWalking", horizontalMovement);
        anim.SetFloat("verticalMovement", verticalMovement);
    }
}
