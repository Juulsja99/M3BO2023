using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageplayer : MonoBehaviour
{

    //dit script doet 2 dingen
    //hij kijkt of er een collision is en hij geeft de speler damage
    // daarom is dit niet SRP
    // dit moet ook los van elkaar kunnen

    private Damage damage;


    private void Start()
    {
        damage= GetComponent<Damage>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            damage.DoDamage();
        }
    }

    
}
