using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgoundMusic : MonoBehaviour
{
    public GameManager gameManager;

    public AudioSource music;
    public AudioSource endsound;

    public bool soundstop;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        soundstop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameOver == true && soundstop == true)
        {
            endsound.Play();
            Debug.Log("playing sounds i promise");

            music.Stop();
            soundstop = false;
        }
    }
}
