using UnityEngine;
using UnityEngine.UI;

public abstract class HealthBarAbstract : MonoBehaviour
{
    [SerializeField] private Health _health;

    public Slider Slider { get; private set; }

    private void Awake()
    {
        Slider = GetComponent<Slider>();
        Slider.maxValue = _health.Max;
        Slider.value = Slider.maxValue;
    }

    private void OnEnable()
    {
        _health.Changed += ChandgedHealthValue;
    }

    private void OnDisable()
    {
        _health.Changed -= ChandgedHealthValue;
    }
    public abstract void ChangeSlider(float healthValue);

    private void ChandgedHealthValue(float healthValue)
    {
        ChangeSlider(healthValue);
    }
}
