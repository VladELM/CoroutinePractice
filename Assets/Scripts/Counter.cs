using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private InputReader _inputHandler;
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private float _increment = 1f;
    [SerializeField] private float _startValue = 0f;

    private Coroutine _coroutine;
    private float _currentValue;
    private bool _isWorking;

    public event Action CounterValueChanged;

    public float CurrentValue => _currentValue;

    private void OnEnable()
    {
        _inputHandler.MouseButtonPushed += TurnSwitch;
    }

    private void Start()
    {
        _currentValue = _startValue;
        _isWorking = false;
    }

    private void OnDisable()
    {
        _inputHandler.MouseButtonPushed -= TurnSwitch;
    }

    private void TurnSwitch()
    {
        _isWorking = !_isWorking;

        if (_isWorking)
        {
            _coroutine = StartCoroutine(Increasing());
        }
        else
        {
            if (_coroutine != null)
                StopCoroutine(_coroutine);
        }
    }

    private IEnumerator Increasing()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(_delay);
            _currentValue += _increment;
            CounterValueChanged?.Invoke();
        }
    }
}
