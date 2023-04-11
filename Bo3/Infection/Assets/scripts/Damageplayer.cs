using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageplayer : MonoBehaviour
{
    [SerializeField] private int Hitdamage;
    [SerializeField] private HealthBar healthbar;

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Damage();
        }
    }

    void Damage()
    {
        healthbar.playerHealth = healthbar.playerHealth - Hitdamage;
        healthbar.updateHealth();
    }
}
