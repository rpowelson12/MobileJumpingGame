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
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(horizontal * movementSpeed * Time.deltaTime,0,0);

    }

    private void HandleJump(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }


}
