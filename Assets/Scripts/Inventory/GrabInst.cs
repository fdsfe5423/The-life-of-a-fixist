using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabInst : MonoBehaviour
{
    public bool iCan;
    public GameObject inst;
    public GameObject point;

    public void INST()
    {
        if(iCan)
        {
            iCan = false;
            Instantiate(inst,point.transform.position,point.transform.rotation);
        }
    }
}
