using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinMovement : MonoBehaviour
{
    public GameObject Player;
    public float speedLazer = 4f;



    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speedLazer * Time.deltaTime);
    }
    
}
