using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movment : MonoBehaviour
{ 
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f; 
    [SerializeField]  private float gravity = 5f;  
    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis ("Vertical") * moveSpeed;
        float straffe = Input.GetAxis ("Horizontal") * moveSpeed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
        transform.Translate (straffe, 0, translation);
        controller.Move(moveDirection * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space)) ;
                if (isJumping == true) ;
                    controller.Move(moveDirection * Time.deltaTime);
                    isJumping = false;
       
        
   
        controller.Move((moveDirection * Time.deltaTime) - gravity);
       

    }
}
