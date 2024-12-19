using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public AudioSource audio;
    public string nameTool;
    public bool iActivate;
    public bool iNeedActivet;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<Repair>().name == nameTool)
        {
           if(iNeedActivet)
            {
                other.gameObject.GetComponent<Repair>().REPAirActivate();
                audio.Play();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Repair>().name == nameTool)
        {
            if (!iNeedActivet)
            {
                other.gameObject.GetComponent<Repair>().REPAir();
            }
        }
    }
}
