using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageplayer : MonoBehaviour
{
    [SerializeField] private int Hitdamage;
    [SerializeField] private HealthBar healthbar;


    //dit script doet 2 dingen
    //hij kijkt of er een collision is en hij geeft de speler damage
    // daarom is dit niet SRP
    // dit moet ook los van elkaar kunnen


    private void Start()
    {
        healthbar = GameObject.Find("HealthController").GetComponent<HealthBar>();
    }
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
