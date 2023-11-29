using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineB : MonoBehaviour
{
    public bool canRun;
    public UnityEvent startEvent, startCountEvent, repeatEvent, endEvent, repeatUntilFalseEvent;
    public IntData counterNum;
    public float seconds = 1.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    public void Start()
    {
        startEvent.Invoke();
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }

    IEnumerator Counting()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startCountEvent.Invoke();
        while (counterNum.value > 0)
        {
            Debug.Log(counterNum);
            repeatEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;

        }
        endEvent.Invoke();
    }

    public void startRepeat()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
    public void stopRepeat()
    {
        canRun = false;
    }

    IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        }
    }
}
