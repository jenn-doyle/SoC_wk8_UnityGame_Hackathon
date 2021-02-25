using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;

    private float timeBetweenSpawn;
    public float startTime;

    //public float decreaseTimeBetweenSpawner;
    //public float minimunTime = 0.65;
    public void Update()
    {
        if (timeBetweenSpawn <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            timeBetweenSpawn = startTime;
            //if (startTime > minimunTime)
        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }

}
