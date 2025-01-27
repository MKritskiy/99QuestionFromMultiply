using TMPro;
using UnityEngine;
[RequireComponent(typeof(PlayerHealth))]
public class HealthUI : MonoBehaviour
{
    public TextMeshPro healthText;
    private PlayerHealth playerHealth;

    private void Start()
    {
        
        playerHealth = GetComponent<PlayerHealth>();
    }
    void Update()
    {
        healthText.text = "HP: "+playerHealth.currentHealth.ToString();
    }
}
