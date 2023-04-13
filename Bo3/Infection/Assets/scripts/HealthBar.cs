using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public int playerHealth;
    public static bool GameOver = false;
    public GameObject GameOverUI;
    [SerializeField] private Image[] hearts;

    void Start()
    {
        //updateHealth();   
    }

    
    void Update()
    {
        if (playerHealth < 1)
        {
           Dead();
        }
        else
        {
            Resume();
        }
    }

    void Dead()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GameOver = true;
    }

    public void Resume()
    {
        GameOverUI.SetActive(false);
        Time.timeScale = 1f;
        GameOver = false;
    }

    public void updateHealth()
    {
        

       for (int i = 0; i < hearts.Length; i++) 
       {
            if (i < playerHealth)
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
