using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float value; 
    // Start is called before the first frame update
    void start()
    {

    }

    public void AddHealth(float healthValue)
    {
        value += healthValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
