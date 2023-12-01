using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroybeh : MonoBehaviour
{
    public float seconds = 1;

    public WaitForSeconds wfsObj;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        yield return wfsObj;
        Destroy(gameObject);
    }
    
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
    

}
