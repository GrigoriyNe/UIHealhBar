using UnityEngine;

public class BottonDirector : MonoBehaviour
{
    [SerializeField] private Health health;

    [SerializeField] private float _damage = 1;
    [SerializeField] private float _heal = 20;

    public void TakeDamage()
    {
        health.TakeDamage(_damage);
    }

    public void RestoreHeal()
    {
        health.RestoreHeal(_heal);
    }
}
