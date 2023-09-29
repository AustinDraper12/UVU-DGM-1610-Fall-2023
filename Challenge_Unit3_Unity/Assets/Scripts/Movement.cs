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
    [SerializeField] private float bounce = 1f; 
    private float turnSpeed;
    private Vector3 moveDirection;
    private bool isJumping;
    private float scale = 5f;
  

    // Start is called before the first frame update
    void Start()
    {
 
        isJumping = true;
        moveSpeed = moveSpeedOg;
        gameObject.transform.localScale = new Vector3(2, 2, 2);

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
//Jumps also allows you to hold it and float for a sec
        if (Input.GetKey(KeyCode.Space))
        {
            if (Input.GetKey(KeyCode.C) || isJumping == false)
            {
                
            }
            else
            {
                isJumping = false;
                transform.Translate(Vector3.up * jumpForce * Time.deltaTime);
                
                isJumping = true;
            } 

        }
        //Crouch
       if (Input.GetKey(KeyCode.C))
       {
           gameObject.transform.localScale = new Vector3(2, 1, 2);
       }
       else 
       {
           gameObject.transform.localScale = new Vector3(2, 2, 2);
       }
       //Sprint incresses speed by adding to the speed and if not pressed goes back
       if (Input.GetKey(KeyCode.V))
       {
           moveSpeed = moveSpeedOg + 10;
       }
       else
       {
           moveSpeed = moveSpeedOg;
       }
// Alternet movement 1 time use super jump
       if (Input.GetKey(KeyCode.B) && bounce < 2)
       {
           
           transform.Translate(Vector3.up * (jumpForce * 100) * Time.deltaTime);
           bounce += 1;

       }
    }

    
}