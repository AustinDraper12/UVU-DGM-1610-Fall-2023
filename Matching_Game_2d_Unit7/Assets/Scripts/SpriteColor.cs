using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteColor : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    
    // Start is called before the first frame update
    void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRenderColor(colorID obj)
    {
        rendererObj.color = obj.value;
    }

    public void ChangeRenderColor(ColorIDDataList obj)
    {
        rendererObj.color = obj.currentColor.value;
    }
}