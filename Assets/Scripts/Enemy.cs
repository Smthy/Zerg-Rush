using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float xMin, xMax, zMin, zMax, yPos;

    public float health = 50f;   

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {         
            Die();
        }
    }

    void Die()
    {
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        SpawningSystem();
        Destroy(gameObject);
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

        Instantiate(gameObject, spawnPos, Quaternion.Euler(0, 0, 0));
    }

}
