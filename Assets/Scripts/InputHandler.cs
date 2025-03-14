using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public event Action MouseButtonPushed;
    
    private int _mouseButtonValue = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(_mouseButtonValue))
            MouseButtonPushed?.Invoke();


    }
}
