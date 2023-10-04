using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float xAxisDistance = 11f;
    public Transform Blaster;
    public GameObject Lazer;
    public GameObject Coin;
    private float coins = 0f;
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 5)
        {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (transform.position.y > - 4)
        {
            if(Input.GetKey(KeyCode.DownArrow))
                transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);
        }

        if (transform.position.x > - xAxisDistance)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (transform.position.x <  xAxisDistance)
        {
            if (Input.GetKey(KeyCode.RightArrow))
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Lazer, Blaster.transform.position, Lazer.transform.rotation);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == Coin)
        {
            coins += 1;
        }
        Debug.Log("coins");
        Destroy(other.gameObject);
    }
}
