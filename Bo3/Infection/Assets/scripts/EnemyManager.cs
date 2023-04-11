using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public Transform[] Spawnpoints;
    public GameObject Enemyprefab;
    
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
        Instantiate(Enemyprefab, Spawnpoints[0].transform.position, Quaternion.identity);
    }
}
