using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
    
public class hit : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
