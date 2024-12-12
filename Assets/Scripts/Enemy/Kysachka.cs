using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Kysachka : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject myTarget;
    public GameObject player;
    public bool trigger;
    public bool ray;
    public bool iCan;
    public bool iCanInvoke;
    public bool iCanCan;
    public float distanceToPLayer;
    public float distanceTarget;
    public int timer;
    public List<GameObject> point = new List<GameObject>();

    private void Start()
    {
        player = GameObject.Find("PlayerOrig");
        gameObject.GetComponent<CapsuleCollider>().radius = distanceTarget/2;
        gameObject.GetComponent<CapsuleCollider>().center = new Vector3(0, 0, (distanceTarget + 0.3f) / 2);
    }

    private void Update()
    {
        distanceToPLayer = Vector3.Distance(transform.position, player.transform.position);
        if(distanceToPLayer < distanceTarget)
        {
            ray = true;
        }
        else
        {
            Invoke("RayFlase", timer);
        }
        if(trigger && ray)
        {
            agent.stoppingDistance = 3;
            agent.SetDestination(player.transform.position);
        }
        else
        {
            if(iCanCan)
            {
                iCan = true; iCanCan = false;
            }
            agent.stoppingDistance = 0;
            if(iCan)
            {
                iCan = false;
                int da = Random.Range(0, point.Count);
                agent.SetDestination(point[da].transform.position);
                myTarget = point[da];
            }
            else if(gameObject.transform.position.x == myTarget.transform.position.x && gameObject.transform.position.z == myTarget.transform.position.z)
            {
                if(iCanInvoke)
                {
                Invoke("ICanTrue", 3f);
                iCanInvoke = false;
                }
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject == player)
        {
            trigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            Invoke("TriggerFalse", timer);
        }
    }

    public void TriggerFalse()
    {
        trigger = false;
    }
    public void RayFlase()
    {
        ray = false;
    }
    public void ICanTrue()
    {
        iCan = true;
        iCanInvoke = true;
    }
}
