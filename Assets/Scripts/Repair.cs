using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    }

    private void Update()
    {
        if(count == maxCount)
        {
            iReapir = true;
            SceneManager.LoadScene("pobeda");
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
