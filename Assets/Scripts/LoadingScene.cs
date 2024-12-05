using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public void LoadLoadingScene()
    {
        SceneManager.LoadScene("Zagryzka");
        DontDestroyOnLoad(this.gameObject);
    }
}
