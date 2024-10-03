using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonAbstract : MonoBehaviour
{
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }
    private void OnEnable()
    {
        _button.onClick.AddListener(ChangeSlider);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeSlider);
    }

    public abstract void ChangeSlider();
}
