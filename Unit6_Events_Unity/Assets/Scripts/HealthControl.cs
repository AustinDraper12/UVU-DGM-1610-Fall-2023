using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthControl : MonoBehaviour
{
    [SerializeField] bool bad;

    [SerializeField] bool good;
    [SerializeField] float health = 5f;
    // Start is called before the first frame update
    void Start()
    {
        good = false;
        bad = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (good == true)
        {
            health += 5;
            good = false;
            Debug.Log(health);
        }
        if (bad == true)
        {
            health -= 5;
            good = false;
            Debug.Log(health);
        }

        if (health <= 0)
        {
            Debug.Log("You have no more health");
        }
    }
}
