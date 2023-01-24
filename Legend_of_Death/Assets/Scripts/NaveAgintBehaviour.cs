using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NaveAgintBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    //public vector3Data playerLoc;
    public vector3Data playerLoc;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = playerLoc.value;
        
    }
}
