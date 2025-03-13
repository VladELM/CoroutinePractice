using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private bool _isProcessing;
    public event Action MouseButtonPushed;

    private void Start()
    {
        _isProcessing = false;
    }

    void Update()
    {
        if (_isProcessing)
            MouseButtonPushed.Invoke();

        if (Input.GetMouseButtonDown(0))
            _isProcessing = !_isProcessing;
    }
}
