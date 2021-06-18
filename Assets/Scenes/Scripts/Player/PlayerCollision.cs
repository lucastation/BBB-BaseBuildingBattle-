using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript;
    
    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private float groundDistance = 0.4f;
    [SerializeField]
    private LayerMask groundMask;

    internal bool isGrounded;


    private void Update()
    {
        checkGround();
    }

    private void checkGround()
    {
        isGrounded = (Physics.CheckSphere(groundCheck.position, groundDistance, groundMask));
    }
}
