using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource noise;
    // Start is called before the first frame update
    void Start()
    {
        noise.Stop();
    }

    public void PlaySound()
    {
        noise.Play();
    }
}
