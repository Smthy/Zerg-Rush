using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float damage = 10f;
    public float range = 50f;

    public Camera fps;
    public GameObject impact;

    public ParticleSystem muzzle;
       
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shooting();
        }
    }

    void Shooting()
    {

        int layer_mask = LayerMask.GetMask("Enemy");

        muzzle.Play();

        RaycastHit hit;
        if(Physics.Raycast(fps.transform.position, fps.transform.forward, out hit, range, layer_mask))
        {
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }

        GameObject impactGO = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impactGO, 0.5f);
    }
}
