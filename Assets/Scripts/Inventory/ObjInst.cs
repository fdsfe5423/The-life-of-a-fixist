using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInst : MonoBehaviour
{
    public string name;
    public GameObject panel;
    public GameObject repairObj;
    public bool ICanActive;
    public bool active;
    public bool iNeedActivate;
    public AudioSource audio;

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
        if(other.gameObject.tag == "Repair" && name == other.gameObject.GetComponent<Repair>().nameTool)
        {
            repairObj = other.gameObject;
            ICanActive = true;
            if(!iNeedActivate)
            {
            other.gameObject.GetComponent<Repair>().REPAir();
            }
            else
            {
                StartCoroutine(Repar());
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        repairObj = null;
        ICanActive = false;
        StopAllCoroutines();
    }
    public IEnumerator Repar()
    {       
          while(true)
          {
            if(active)
            {
              audio.Play();
              repairObj.GetComponent<Repair>().REPAirActivate();
              yield return new WaitForSeconds(0.3f);
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
    public void Active()
    {
        active = true; 
    }
    public void DesActive()
    {
        active = false;
    }
}
