using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour
{
   public List<string> strings = new List<string>();

    void Update()
    {
        for(int i = 0; i < strings.Count; i++)
        {
            
            if(PlayerPrefs.GetInt(strings[i]) == 1)
            {
                Invoke("Da", 1f);
            }
            else
            {
                CancelInvoke("Da");
            }
        }
    }
    public void Da()
    {
        SceneManager.LoadScene(1);
    }
}
