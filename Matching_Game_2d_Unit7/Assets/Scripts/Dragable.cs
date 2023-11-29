using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dragable : MonoBehaviour
{
    private Camera cameraObj;

    public bool dragable;

    public Vector2 position, offset;

    public UnityEvent StartDrag, EndDrag;
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = (transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition));
        StartDrag.Invoke();
        yield return new WaitForFixedUpdate();
        dragable = true;
        yield return new WaitForFixedUpdate();
        
        
        while (dragable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition);
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        EndDrag.Invoke();
        dragable = false;
    }
}
