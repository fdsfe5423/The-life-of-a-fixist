using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Kysachka : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("PlayerOrig");
    }

    private void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
