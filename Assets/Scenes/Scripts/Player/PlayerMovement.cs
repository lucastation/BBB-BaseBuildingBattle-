using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript;
    [SerializeField]
    private CharacterController controller;
    [SerializeField]
    private float speed = 12f;
    [SerializeField]
    private float gravity = -30.81f;
    [SerializeField]
    private float jumpHeight = 3f;

    private Vector3 velocity; 

    void Update()
    {

        applyGravity();
    }

    internal void Move(float x, float z)
    {
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }

    internal void Jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }

    private void applyGravity()
    {
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
