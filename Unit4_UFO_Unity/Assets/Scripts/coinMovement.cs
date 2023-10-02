using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinMovement : MonoBehaviour
{
    public float speedLazer = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speedLazer * Time.deltaTime);
    }
}
