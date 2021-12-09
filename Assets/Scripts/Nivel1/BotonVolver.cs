using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BotonVolver : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent buttonClick;

    void Awake()
    {
        if (buttonClick == null)
        {
            buttonClick = new UnityEvent();
        }
    }
    // Start is called before the first frame update
    private void OnMouseUp()
    {
        buttonClick.Invoke();
    }
}
