using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private float spawnInterval = 2f;
    [SerializeField] private float spawnDelay = 2f;

    private void Start()
    {        
        InvokeRepeating("SpawnObstacle", spawnDelay,spawnInterval);
    }

    public virtual void SpawnObstacle()
    {

        int obstacleIndex = Random.Range(0, obstacles.Length);
        GameObject obstacle = obstacles[obstacleIndex];
        Instantiate(obstacle, transform);
    }

}
