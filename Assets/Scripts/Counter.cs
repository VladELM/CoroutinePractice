using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private float _increment = 1f;
    [SerializeField] private float _startValue = 0f;

    private float _currentValue;

    private void Start()
    {
        _currentValue = _startValue;
    }

    private void OnEnable()
    {
        _inputHandler.MouseButtonPushed += ChangeValue;
    }

    private void OnDisable()
    {
        _inputHandler.MouseButtonPushed -= ChangeValue;
    }

    private void ChangeValue()
    {
        _textMeshPro.text = Convert.ToString(_currentValue);
        StartCoroutine(Increase());
    }

    private IEnumerator Increase()
    {
        _currentValue += _increment;
        yield return new WaitForSeconds(_delay);
    }
}
