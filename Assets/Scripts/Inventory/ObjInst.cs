using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInst : MonoBehaviour
{
    public string name;
    public GameObject panel;

    private void Start()
    {
        panel = GameObject.Find(name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "DropCol")
        {
            panel.GetComponent<GrabInst>().iCan = true;
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "Repair" && gameObject.name == other.gameObject.GetComponent<Repair>().nameTool)
        {
            other.gameObject.GetComponent<Repair>().REPAir();
        }
    }
}
