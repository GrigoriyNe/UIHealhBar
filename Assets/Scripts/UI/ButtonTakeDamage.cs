using UnityEngine;

public class ButtonTakeDamage : ButtonAbstract
{
    [SerializeField] private Health _health;
    [SerializeField] private float _damage = 10;

    public override void ChangeSlider()
    {
        _health.TakeDamage(_damage);
    }
}
