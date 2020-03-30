using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{
    public float Base = 100f;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Base = Base - 10f;
        }
    }

    void Update()
    {
        if(Base <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
