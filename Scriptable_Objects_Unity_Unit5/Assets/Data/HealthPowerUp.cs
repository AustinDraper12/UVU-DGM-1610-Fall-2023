using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    [SerializeField] private FloatData healthValue;
    // Start is called before the first frame update
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Apply the health value to the player
            ApplyHealth(other.gameObject);

            // Destroy the power-up game object
            Destroy(gameObject);
        }
    }

    private void ApplyHealth(GameObject player)
    {
            // Retrieve the player's health component (e.g., HealthController script)
        HealthController healthController = player.GetComponent<HealthController>();
   
            // Check if the player has a health component
        if (healthController != null)
        {
            healthController.AddHealth(healthValue.Value);
        }
    }

}
