using TMPro;
using UnityEngine;

public class ViewValueHealth : MonoBehaviour
{
    [SerializeField] private Health _health;

    private TMP_Text _text;

    private void OnEnable()
    {
        _text = GetComponent<TMP_Text>();
        _health.Changed += ChangeValueHealth;
        _text.text = (_health.Max + "/" + _health.Max);
    }

    private void OnDisable()
    {
        _health.Changed -= ChangeValueHealth;
    }

    private void ChangeValueHealth(float healthValue)
    {
        _text.text = (healthValue.ToString() + "/" + _health.Max);
    }
}
