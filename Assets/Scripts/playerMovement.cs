using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    
    public float speed = 12f;
    public float gravity = -5f;
    public float jumpHeight = 3f;
    public float strength = 100;

    private Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;

    public LayerMask groundMask;

    private bool isGrounded;

    public GameObject player;


    void Update()
    {
        Move();
        Sprint();       
    }

    void Move()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void Sprint()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }
    }
}
