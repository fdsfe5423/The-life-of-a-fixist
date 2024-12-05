using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject glavMenu;
    public GameObject dopInf;
    public GameObject zag;
    [SerializeField] TextMeshProUGUI loadPercent;
    [SerializeField] Animator animator;

    public void exit()
    {
        Application.Quit();
    }

    public void inf()
    {
        glavMenu.SetActive(false);
        dopInf.SetActive(true);
    }
    public void nazad()
    {
        dopInf.SetActive(false); glavMenu.SetActive(true);
    }
    public void play()
    {
        SceneManager.LoadScene("Zagryzka");
    }

    IEnumerator Load()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("GameHome");

        while (!operation.isDone)
        {
            if (operation.progress < 0.9f)
            {
                loadPercent.text = (operation.progress * 100f).ToString("F0") + "%";
            }
            else
            {
                loadPercent.text = "100%";
            }
        }
        yield return null;
    }
}
