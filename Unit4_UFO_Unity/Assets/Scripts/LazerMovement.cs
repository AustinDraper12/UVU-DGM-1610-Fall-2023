using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerMovement : MonoBehaviour
{
    public float speedLazer = 6f;

    public ScoreManager scoreManager;

    public int scoreToGive;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
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
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}

