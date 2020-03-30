using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;

    public float xMin, xMax, zMin, zMax, yPos;

    void Start()
    {
        SpawningSystem();
    }

    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        Gizmos.DrawSphere(new Vector3(xMin, yPos, zMin), 0f);
        Gizmos.DrawSphere(new Vector3(xMin, yPos, zMax), 0f);
        Gizmos.DrawSphere(new Vector3(xMax, yPos, zMin), 0f);
        Gizmos.DrawSphere(new Vector3(xMax, yPos, zMax), 0f);
    }

    public void SpawningSystem()
    {
        float xPos = Random.Range(xMin, xMax);
        float zPos = Random.Range(zMin, zMax);

        Vector3 spawnPos = new Vector3(xPos, yPos, zPos);

        Instantiate(enemy, spawnPos, Quaternion.Euler(0, 0, 0));
    }
}
