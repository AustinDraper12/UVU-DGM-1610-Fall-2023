using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UFO_move : MonoBehaviour
{
    public float speed = 4f;

    public AudioSource explosionSound;
    public GameObject explode;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Lazer")
        {
            Debug.Log("sound play here");
            Instantiate(explode);
        }

    }
}
