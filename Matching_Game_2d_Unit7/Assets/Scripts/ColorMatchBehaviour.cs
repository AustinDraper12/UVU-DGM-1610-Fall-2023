using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehaviour : Match
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }

    public void changeColor(SpriteRenderer renderer)
    {
        var newcolor = idObj as colorID;
        renderer.color = newcolor.value;

    }
}
