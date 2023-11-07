using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Material))]
public class SpriteColor : MonoBehaviour
{
    private Material rendererObj;
    
    // Start is called before the first frame update
    void Start()
    {
        rendererObj = GetComponent<Material>();
    }

    public void ChangeRenderColor(colorID obj)
    {
        rendererObj.color = obj.value;
    }

}
