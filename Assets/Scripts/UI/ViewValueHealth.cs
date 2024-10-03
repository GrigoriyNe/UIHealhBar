using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class ViewValueHealth : MonoBehaviour
{
    [SerializeField] private Health _health;

    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
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
