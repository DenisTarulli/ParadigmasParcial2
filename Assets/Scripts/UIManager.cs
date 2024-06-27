using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;

    private void UpdateHealth(int newHealth)
    {
        healthText.text = $"HP: {newHealth}";
    }

    private void OnEnable()
    {
        PlayerHealth.OnHurt += UpdateHealth;
    }

    private void OnDisable()
    {
        PlayerHealth.OnHurt -= UpdateHealth;
    }
}
