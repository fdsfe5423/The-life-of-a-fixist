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

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<Repair>().name == nameTool)
        {
           if(iNeedActivet)
            {
                triggerObj = other.gameObject;
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
    public IEnumerator Active()
    {
        if(iActivate)
        {
            gameObject.GetComponent<Repair>().REPAirActivate();
            audio.Play();
        }
        yield return new WaitForSeconds(0.3f);
    }
}
