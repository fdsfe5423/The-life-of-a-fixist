using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pzhSrabotai : MonoBehaviour
{
    public int o;
    public BoxCollider box;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
        {
            print(o);
            o++;
            audioSource.Play();
            box.isTrigger = false;
            if (o >= 0)
            {
                SceneManager.LoadScene("pobeda");
            }
            
        }
    }
}
