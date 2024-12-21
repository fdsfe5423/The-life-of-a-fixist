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
}
