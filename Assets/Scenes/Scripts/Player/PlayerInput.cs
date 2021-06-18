using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript;


    private void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        playerScript.movementScript.Move(x, z);

        if (Input.GetButtonDown("Jump") && playerScript.collisionScript.isGrounded)
        {
            playerScript.movementScript.Jump();
        }


    }
}
