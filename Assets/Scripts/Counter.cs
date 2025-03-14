using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private float _increment = 1f;
    [SerializeField] private float _startValue = 0f;

    private Coroutine _coroutine;
    private float _currentValue;

    public float CurrentValue => _currentValue;

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
        _coroutine = StartCoroutine(Increase());
        _currentValue += _increment;
    }

    private IEnumerator Increase()
    {
        yield return new WaitForSeconds(_delay);
    }
}
