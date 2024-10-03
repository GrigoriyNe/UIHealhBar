using UnityEngine;

public class ButtonTakeHeal : ButtonAbstract
{
    [SerializeField] private Health _health;
    [SerializeField] private float _heal = 20f;

    public override void ChangeSlider()
    {
        _health.RestoreHeal(_heal);
    }
}
