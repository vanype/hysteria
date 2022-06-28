using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] Enemies;

    public float Dir;
    float waitTime;
    public int maxWaitTime;
    public int maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    IEnumerator Spawn()
    {
        while (true)
        {
            int randomEnemy;
            int randomSpeed;
            int randomTime;
            randomEnemy = Random.Range(0, Enemies.Length);
            randomTime = Random.Range(1, maxWaitTime);
            randomSpeed = Random.Range(1, maxSpeed);
            waitTime = randomTime;
            if (randomSpeed < 3)
            {
                GameObject gm = Instantiate(Enemies[randomEnemy], this.transform);
            }
            
            yield return new WaitForSeconds(waitTime);
        }
    }
    
}