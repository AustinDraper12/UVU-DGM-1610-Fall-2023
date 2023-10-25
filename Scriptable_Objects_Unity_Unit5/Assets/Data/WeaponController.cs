using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void AddAmmo(int ammoValue)
    {
        value += ammoValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
