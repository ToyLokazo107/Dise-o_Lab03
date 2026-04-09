using UnityEngine;
using UnityEngine.AI;

public class AgentSimpleContoller : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        GameObject obj = GameObject.FindGameObjectWithTag("Player");
        if (obj != null)
        {
            player = obj.transform;
        }
    }

    void Update()
    {
        if (agent != null && player != null)
        {
            agent.SetDestination(player.position);
        }
    }
}