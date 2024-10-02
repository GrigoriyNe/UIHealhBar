using UnityEngine;

public class HealthBarSmooth : HealthBarAbstract
{
    private float _smoothValue = 0.5f;

    private void Update()
    {
        float currentValue = Slider.value;
        Slider.value = Mathf.MoveTowards(currentValue, HealthValue, _smoothValue);
    }
}
