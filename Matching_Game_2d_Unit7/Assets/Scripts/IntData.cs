using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntData : MonoBehaviour
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }

}
