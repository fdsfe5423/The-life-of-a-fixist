using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class PODAROK : MonoBehaviour
{
    public GameObject canvas;
    public GameObject podarok;
    public AudioSource zvyk;
    public AudioSource zvxk;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<XROrigin>()!= null)
        {
            podarok.SetActive(false);
            canvas.SetActive(true);
            zvyk.Play();
            zvxk.Play();
        }
    }
}
