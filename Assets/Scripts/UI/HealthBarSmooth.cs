using UnityEngine;

public class HealthBarSmooth : HealthBarAbstract
{
    [SerializeField, Min(0.01f)] private float _smoothValue = 0.5f;

    private void Update()
    {
        float currentValue = Slider.value;
        Slider.value = Mathf.MoveTowards(currentValue, HealthValue, _smoothValue);
    }
}
