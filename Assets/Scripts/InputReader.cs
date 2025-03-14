using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private int _mouseButtonValue = 0;

    public event Action MouseButtonPushed;

    private void Update()
    {
        if (Input.GetMouseButtonDown(_mouseButtonValue))
            MouseButtonPushed?.Invoke();
    }
}
