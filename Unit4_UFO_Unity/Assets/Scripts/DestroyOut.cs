using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOut : MonoBehaviour
{
    public float upperBound = 8f;
    public float lowerBound = -7f;
    public GameObject Coin;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > upperBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < lowerBound)
        {
            if (gameObject == Coin)
            {
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Game Over");
                Destroy(gameObject);
                Time.timeScale = 0;  
            }
           
        }
    }
}
