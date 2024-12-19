using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gvozd1 : MonoBehaviour
{
    public GameObject gvozd;
    public GameObject gvozd2;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("molotok"))
        {
            gvozd.SetActive(false);
            gvozd2.SetActive(!false);
        }
    }
}
