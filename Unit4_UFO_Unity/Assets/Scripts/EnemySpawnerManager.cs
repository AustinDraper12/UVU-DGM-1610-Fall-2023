using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerManager : MonoBehaviour
{
    public GameObject[] UFO_Prefabs;
    public Transform enemySpawner;
    public float upperBound = 8f;
    public float delay = 10f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        if (timer > delay)
        {
            float randomNumber = Random.Range(-10, 10);
            int UFO_Index = Random.Range(0, 3);
            transform.position = new Vector3(randomNumber, upperBound - 1, 0f);
            Instantiate(UFO_Prefabs[UFO_Index], enemySpawner.transform.position,
                UFO_Prefabs[UFO_Index].transform.rotation);
            timer -= delay;
        }
        
    }
}

