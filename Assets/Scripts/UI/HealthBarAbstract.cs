using UnityEngine;
using UnityEngine.UI;

public abstract class HealthBarAbstract : MonoBehaviour
{
    [SerializeField] public Health Health;

    public Slider Slider;
    public float HealthValue;

    private void OnEnable()
    {
        Slider = GetComponent<Slider>();
        Slider.maxValue = Health.Max;
        HealthValue = Health.Max;
        Slider.value = HealthValue;
        Health.Changed += GetHealthValue;
    }

    private void OnDisable()
    {
        Health.Changed -= GetHealthValue;
    }

    private void GetHealthValue(float healthValue)
    {
        HealthValue = healthValue;

        if (Slider.value <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
