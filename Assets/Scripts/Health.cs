using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    private float _min = 0;

    public float Max { get; private set; } = 100;
    public float Value { get; private set; }


    public event UnityAction<float> Changed;

    private void Awake()
    {
        Value = Max;
    }

    public void TakeDamage(float damage)
    {
        Value -= Mathf.Clamp(damage, _min, Max);
        Changed?.Invoke(Value);
    }

    public void RestoreHeal(float heal)
    {
        if (Value + heal > Max)
        {
            Value = Max;
        }
        else
        {
            Value += Mathf.Clamp(heal, _min, Max);
        }

        Changed?.Invoke(Value);
    }
}