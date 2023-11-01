using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
    
public class hit : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    // Start is called before the first frame update
    public GameObject Player;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("good"))
        {
            triggerEnterEvent.Invoke();
            Debug.Log("cheese");
        }

    }

}
