using Mirror;
using UnityEngine;

public class DamageDealer : NetworkBehaviour
{
    public float damageAmount = 10f;

    void OnTriggerEnter(Collider other)
    {
        if (!isServer) return;
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageAmount);
        }
    }
}
