using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gvozd1 : MonoBehaviour
{
    public GameObject gvozd;

    private void Update()
    {
        if (GetComponent <Repair>().count == GetComponent<Repair>().maxCount)
        {
            gvozd.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
