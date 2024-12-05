using TMPro;
using UnityEngine;

public class Repair : MonoBehaviour
{
    public string nameTool;
    public int count;
    public int maxCount;
    public int random;
    public bool iReapir;
    public GameObject voskliclSnak;
    public TextMeshProUGUI text;
    public AudioSource audio;

    [SerializeField] private string sceneName;

    private void Start()
    {
        random = Random.Range(1, 4);
        if(random == 1)
        {
            count = Random.Range(0, 10);
        }
        else
        {
            count = maxCount;
        }

        
    }

    private void Update()
    {
        text.text = count.ToString() + "/" + maxCount.ToString();
        if(count == maxCount)
        {
            iReapir = true;
            voskliclSnak.SetActive(false);
            PlayerPrefs.SetInt(sceneName, 1);
            PlayerPrefs.Save();
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
