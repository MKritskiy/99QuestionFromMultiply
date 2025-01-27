using Mirror;
using UnityEngine;

public class PlayerHealth : NetworkBehaviour
{
    [SyncVar]
    public float currentHealth;
    public float maxHealth = 100f;
    void Start()
    {

        currentHealth = maxHealth;

    }

    [Server]
    public void TakeDamage(float amount)
    {
        if (!isServer) return;

        currentHealth -= amount;
        Debug.Log(currentHealth);
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }

    }

    void Die()
    {
        Debug.Log("Player has died.");
    }
}
