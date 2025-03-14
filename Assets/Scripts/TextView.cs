using TMPro;
using UnityEngine;

public class TextView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _textMeshPro;

    private void OnEnable()
    {
        _counter.CounterValueChanged += DisplayValue;
    }

    private void Start()
    {
        _textMeshPro.text = _counter.CurrentValue.ToString();
    }

    private void OnDisable()
    {
        _counter.CounterValueChanged -= DisplayValue;
    }

    private void DisplayValue()
    {
        _textMeshPro.text = _counter.CurrentValue.ToString();
    }
}
