using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;
    
    // Start is called before the first frame updat
    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    // Update is called once per frame
    void start()
    {
        gameOverText = GameObject.Find("gameOverText");
    }

    void Update()
    {
        if (isGameOver)
        {
            EndGame();
        }
        else
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
