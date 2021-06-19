using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class clickHandler : MonoBehaviour
{
    public UnityEvent upEvent;
    public UnityEvent downEvent;
    void OnMouseDown()
    {
        Debug.Log("down");
        downEvent?.Invoke();
    }

    void OnMouseUp()
    {
        Debug.Log("up");
        upEvent?.Invoke();
    }
}
