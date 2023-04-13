using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public Transform[] Spawnpoints;
    public GameObject Enemyprefab;
    public AudioSource zombieSpawn;
    
    void Start()
    {
        SpawnNewEnemy();
    }

   void OnEnable()
   {
        KillHit.OnEnemyKilled += SpawnNewEnemy;
            
   }

    void SpawnNewEnemy()
    {
        int randomNumber = Mathf.RoundToInt(Random.Range(0f, Spawnpoints.Length - 1));
        Instantiate(Enemyprefab, Spawnpoints[randomNumber].transform.position, Quaternion.identity);
        zombieSpawn.Play();
    }
}
