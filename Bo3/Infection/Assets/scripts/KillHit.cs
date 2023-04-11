using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillHit : MonoBehaviour
{

    public string targetTag;
    public GameObject effect;
    private AudioSource sound;
    public delegate void EnemyKilled();
    public static event EnemyKilled OnEnemyKilled;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            Debug.Log("Hit");
        }
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            Debug.Log("Hit");
            Destroy(coll.gameObject, 0.1f);
        }

        if (OnEnemyKilled != null)
        {
            OnEnemyKilled();
        }
    }

    
}
