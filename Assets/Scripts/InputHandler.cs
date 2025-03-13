using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private bool _isProcessing;
    public event Action MouseButtonPushed;

    void Update()
    {
        if (_isProcessing)
            MouseButtonPushed.Invoke();

        if (Input.GetMouseButtonDown(0))
            _isProcessing = !_isProcessing;
    }
}
