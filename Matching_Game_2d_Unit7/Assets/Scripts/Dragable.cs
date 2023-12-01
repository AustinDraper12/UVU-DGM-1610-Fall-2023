using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dragable : MonoBehaviour
{
    private Camera cameraObj;

    public bool dragable;

    public Vector3 position, offset;

    public UnityEvent StartDrag, EndDrag;
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = (transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition));
        dragable = true;
        StartDrag.Invoke();

        yield return new WaitForFixedUpdate();
        
        
        while (dragable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        EndDrag.Invoke();
        dragable = false;
    }
}
