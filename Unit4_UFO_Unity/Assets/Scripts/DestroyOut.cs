using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOut : MonoBehaviour
{
    public float upperBound = 7f;
    public float lowerBound = -6f;
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 1;
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
            Debug.Log("Game Over");
            Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }
}
