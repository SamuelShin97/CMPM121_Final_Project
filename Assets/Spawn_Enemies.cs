using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemies : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemy;
    public int enemy_count = 3;
    public int[] repeat;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {

            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            repeat[i] = spawnPointIndex;
            if (i == 1)
            {
                while (spawnPointIndex == repeat[0])
                {
                    spawnPointIndex = Random.Range(0, spawnPoints.Length);
                }
            }
            if(i == 2)
            {
                while (spawnPointIndex == repeat[0] || spawnPointIndex == repeat[1])
                {
                    spawnPointIndex = Random.Range(0, spawnPoints.Length);
                }
            }
            Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy_count < 3)
        {
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            enemy_count++;
        }
        
    }
}
