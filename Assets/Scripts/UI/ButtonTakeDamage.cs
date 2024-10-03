using UnityEngine;

public class ButtonTakeDamage : ButtonAbstract
{
    [SerializeField] private float _damage = 1;

    private void OnEnable()
    {
        Button.onClick.AddListener(TakeDamage);
    }

    public void TakeDamage()
    {
        Health.TakeDamage(_damage);
    }
}
