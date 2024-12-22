using TMPro;
using UnityEngine;

public class Repair : MonoBehaviour
{
    public string nameTool;
    public int count;
    public int maxCount;
    public int random;
    public bool iReapir;
    public TextMeshProUGUI text;
    public AudioSource audio;

    private void Start()
    {
        count = Random.Range(0, 10);        
    }

    private void Update()
    {
        text.text = "Целостность: " + count.ToString() + "/" + maxCount.ToString();
        if(count == maxCount)
        {
            iReapir = true;
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
