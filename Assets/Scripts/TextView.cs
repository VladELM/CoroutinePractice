using TMPro;
using UnityEngine;

public class TextView : MonoBehaviour
{
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _textMeshPro;

    private void OnEnable()
    {
        _inputHandler.MouseButtonPushed += DisplayValue;
    }

    private void OnDisable()
    {
        _inputHandler.MouseButtonPushed -= DisplayValue;
    }

    private void DisplayValue()
    {
        _textMeshPro.text = _counter.CurrentValue.ToString();
    }
}
