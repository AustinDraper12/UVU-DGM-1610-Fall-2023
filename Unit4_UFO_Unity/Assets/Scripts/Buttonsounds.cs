using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonsounds : MonoBehaviour
{
    public AudioSource ButtonPress;
    
    // Start is called before the first frame update
    public void PressedButton()
    {
        ButtonPress.Play ();
    }


}
