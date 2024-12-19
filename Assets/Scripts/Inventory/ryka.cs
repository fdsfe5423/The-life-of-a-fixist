using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ryka : MonoBehaviour
{
    public GameObject pomogator;
    public GameObject ypravlenie;
    public GameObject zadaniya;

    public void zadanizza()
    {
        pomogator.SetActive(false);
        ypravlenie.SetActive(false);
        zadaniya.SetActive(!false);
    }
    public void pomosch()
    {
        pomogator.SetActive(true);
        ypravlenie.SetActive(!true);
        zadaniya.SetActive(!true);
    }
    public void pravlenie()
    {
        pomogator.SetActive(!true);
        ypravlenie.SetActive(true);
        zadaniya.SetActive(!true);
    }
}
