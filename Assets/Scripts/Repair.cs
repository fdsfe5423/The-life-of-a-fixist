using TMPro;
using UnityEngine;

public class Repair : MonoBehaviour
{
    public string nameTool;
    public int count;
    public int maxCount;
    public bool iReapir;
    public GameObject voskliclSnak;
    public TextMeshProUGUI text;
    public AudioSource audio;

    private void Update()
    {
        text.text = count.ToString() + "/" + maxCount.ToString();
        if(count == maxCount)
        {
            iReapir = true;
            voskliclSnak.SetActive(false);
        }
    }

    public void REPAir()
    {
        audio.Play();
        if(count < maxCount)
        {
        count++;
        }
    }
    public void REPAirActivate()
    {
        if (count < maxCount)
        {
            count++;
        }
    }
}
