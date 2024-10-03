using UnityEngine;

public class ButtonTakeHeal : ButtonAbstract
{
    [SerializeField] private float _heal = 20;

    private void OnEnable()
    {
        Button.onClick.AddListener(RestoreHeal);
    }

    public void RestoreHeal()
    {
        Health.RestoreHeal(_heal);
    }
}
