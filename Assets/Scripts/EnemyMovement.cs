using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public GameObject endGoal;

    public MonoBehaviour movement;


    public bool travel;

    void Awake()
    {
        endGoal = GameObject.FindGameObjectWithTag("EndGoal");
        movement.enabled = true;
    }

    void Start()
    {
        

        gameObject.GetComponent<NavMeshAgent>().enabled = true;
        navMeshAgent = GetComponent<NavMeshAgent>();
        SetDest();
    }

    void Update()
    {
        Vector3 target;
        target = endGoal.transform.position;
        navMeshAgent.SetDestination(target);        
    }

    void SetDest()
    {
        travel = true;
    }
}
