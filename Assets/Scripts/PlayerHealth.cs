using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    private int currentHealth;

    public static event Action<int> OnHurt;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void TakeDamage(int damageToTake)
    {
        currentHealth -= damageToTake;

        OnHurt?.Invoke(currentHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            TakeDamage(10);
    }
}

