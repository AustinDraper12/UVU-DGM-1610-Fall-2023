using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerMovement : MonoBehaviour
{
    public float speedLazer = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speedLazer * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Finish")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}

