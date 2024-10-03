using System.Collections;
using UnityEngine;

public class HealthBarSmooth : HealthBarAbstract
{
    [SerializeField, Min(10f)] private float _smoothValue = 50f;

    private Coroutine _coroutine;
    private float _currentValue;

    public override void ChangeSlider(float healthValue)
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);
        
        _currentValue = Slider.value;
        _coroutine = StartCoroutine(ChangeSliderSmooth(healthValue));
    }

    private IEnumerator ChangeSliderSmooth(float healthValue)
    {
        while (_currentValue != healthValue)
        {
            Slider.value = Mathf.MoveTowards(_currentValue, healthValue, _smoothValue * Time.deltaTime);
            _currentValue = Slider.value;

            yield return null;
        }
    }
}
