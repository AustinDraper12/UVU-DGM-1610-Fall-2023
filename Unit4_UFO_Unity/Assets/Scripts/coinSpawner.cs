using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{
    public GameObject Coin;
    public Transform CoinSpawner;
    public float upperBound = 8f;
    public float delay = 10f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Coin, CoinSpawner.transform.position, Coin.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        // returns a random number between -10 and 10
         timer += Time.deltaTime;
            if (timer > delay)
            {
                float randomNumber = Random.Range(-10, 10);
                transform.position = new Vector3(randomNumber, upperBound - 1, 0f);
                Instantiate(Coin, CoinSpawner.transform.position, Coin.transform.rotation);
                timer -= delay;
            }
        
    }
}
