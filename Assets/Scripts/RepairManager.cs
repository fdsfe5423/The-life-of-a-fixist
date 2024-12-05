using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairManager : MonoBehaviour
{
    public List<Repair> objRep = new List<Repair>();
    public bool SceneComplete;

    private void Update()
    {
        SceneComplete = true;
        for (int i = 0; i < objRep.Count; i++)
        {
            if (objRep[i].iReapir == false)
            {
                SceneComplete = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Repair>())
        {
            objRep.Add(other.gameObject.GetComponent<Repair>());
        }
    }
}
