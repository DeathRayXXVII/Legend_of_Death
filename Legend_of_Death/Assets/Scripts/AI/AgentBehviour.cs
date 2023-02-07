using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentBehviour : MonoBehaviour
{
    private NavMeshAgent agent;
    public float remainingDistanceNum = 0.5f;
    public Transform player;
    public List<Transform> patrolPointList;
    private int i;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        agent.destination = player.position;

        if (agent.pathPending || !(agent.remainingDistance < remainingDistanceNum)) return;
        agent.destination = patrolPointList[i].position;
        i = (i + 1) % patrolPointList.Count;
    }
}
