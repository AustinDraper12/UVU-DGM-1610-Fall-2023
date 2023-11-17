using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehavouir : IDContainer
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
