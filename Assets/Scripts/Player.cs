using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpHeight;
    [SerializeField] private float movementSpeed;
    [SerializeField] private Rigidbody2D playerRb;
    private float horizontal;


    void Update()
    {
        HandleJump();
        HandleMovement();
    }

    private void HandleMovement()
    {
        //////////////////////// Attempt at sprints
        // if (Input.GetKey(KeyCode.LeftShift))
        // {
        //     movementSpeed = 15;
        // }
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.position += Vector3.right * horizontal * movementSpeed * Time.deltaTime;



    }

    private void HandleJump(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }


}
