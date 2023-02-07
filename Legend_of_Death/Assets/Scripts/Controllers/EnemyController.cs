using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController: MonoBehaviour
{
    public float lookRadius = 10f;
    private NavMeshAgent agent;
    public float remainingDistanceNum = 0.5f;
    public List<Transform> patrolPointList;
    private int i;

    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distacne = Vector3.Distance(target.position, transform.position);

        if (distacne <= lookRadius)
        {
            agent.SetDestination((target.position));

            if (distacne <= agent.stoppingDistance)
            {
                // Attack the target
                FaceTarget();
            }
        }
        else
        {
            if (agent.pathPending || !(agent.remainingDistance < remainingDistanceNum)) return;
            agent.destination = patrolPointList[i].position;
            i = (i + 1) % patrolPointList.Count;
        }
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.x));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
