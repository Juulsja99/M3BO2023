using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int playerHealth;
    [SerializeField] private Image[] hearts;

    void Start()
    {
      //updatehealt   
    }

    
    void Update()
    {
        //updateHealth();
    }

    public void updateHealth()
    {
        if (playerHealth< 0) 
        {
            //restartmenu
        }

       for (int i = 0; i < hearts.Length; i++) 
       {
            if ( i < playerHealth)
            {
                hearts[i].color = Color.red;
            }
            else
            {
                hearts[i].color = Color.black;
            }
       } 
    }
}
