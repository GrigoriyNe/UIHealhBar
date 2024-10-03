using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonAbstract : MonoBehaviour
{
    [SerializeField] public Health Health;

    public Button Button;

    private void Awake()
    {
        Button = GetComponent<Button>();
    }
}
