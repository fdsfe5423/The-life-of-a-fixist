using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    public TextMeshProUGUI loadPercent;
    public Animator animator;

    private void Start()
    {
        animator.enabled = true;
        StartCoroutine(Load());
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
            yield return null;
        }
        yield return null;
    }
}

