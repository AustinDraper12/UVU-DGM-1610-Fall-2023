using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<colorID> colorIDList;

    public colorID currentColor;

    private int num;

    public void SetCurrentColorRandom()
    {
        num = Random.Range(0,3);
        currentColor = colorIDList[num];
    }


}
