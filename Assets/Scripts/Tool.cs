using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public AudioSource audio;
    public string nameTool;
    public bool iActivate;
    public bool iNeedActivet;
    public GameObject triggerObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Repair>().name == nameTool)
        {
           other.gameObject.GetComponent<Repair>().REPAir();
        }
    }
}
