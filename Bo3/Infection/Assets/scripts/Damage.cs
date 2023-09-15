using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    [SerializeField] private int Hitdamage;
    [SerializeField] private HealthBar healthbar;

    private void Start()
    {
        healthbar = GameObject.Find("HealthController").GetComponent<HealthBar>();
    }

    public void DoDamage()
    {
        healthbar.playerHealth = healthbar.playerHealth - Hitdamage;
        healthbar.updateHealth();
    }

}
