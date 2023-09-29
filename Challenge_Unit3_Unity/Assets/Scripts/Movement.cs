using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeedOg = 2f;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float jumpForce = 1f; 
    private float turnSpeed;
    private Vector3 moveDirection;
    private bool isJumping;
    private float scale = 5f;
  

    // Start is called before the first frame update
    void Start()
    {
 
        isJumping = true;
        moveSpeed = moveSpeedOg;


    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
//Jumps
        if (Input.GetKey(KeyCode.Space))
        {
            if (Input.GetKeyDown(KeyCode.C) || isJumping == false)
            {
                
            }
            else
            {
                isJumping = false;
                transform.Translate(Vector3.up * jumpForce * Time.deltaTime);
                
                isJumping = true;
            } 

        }
       if (Input.GetKey(KeyCode.C))
       {
           
       }
       else 
       {
           
       }
       if (Input.GetKey(KeyCode.C))
       {
           moveSpeed = moveSpeedOg + 10;
       }
       else
       {
           moveSpeed = moveSpeedOg;
       }
    }

    
}