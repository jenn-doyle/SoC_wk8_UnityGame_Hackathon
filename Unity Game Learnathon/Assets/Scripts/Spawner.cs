using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float timeBetweenSpawn;
    public float startTime;
    public float decreaseTimeBetweenSpawner;
    public float minimunTime = 0.65f;

    public void Update()
    {
        if (timeBetweenSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            //Debug.Log(rand);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBetweenSpawn = startTime;
            if (startTime > minimunTime)
            {
                startTime -= decreaseTimeBetweenSpawner;
            }
        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }

}
