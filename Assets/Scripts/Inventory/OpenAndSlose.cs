using UnityEngine.InputSystem;
using UnityEngine;
using JetBrains.Annotations;
using System.Collections;
using Unity.VisualScripting;

public class OpenAndSlose : MonoBehaviour
{
    public GameObject UI;
    public bool isOpen;
    public bool iCAn;
    public InputActionProperty action;

    private void Update()
    {
        bool iNT = action.action.IsPressed();
        if (iNT && iCAn)
        {
            if (isOpen)
            {
                UI.SetActive(true);
                isOpen = false;
            }
            else
            {
                UI.SetActive(false);
                isOpen = true;

            }
            Invoke("CD", 1f);
            iCAn = false;
        }
    }
    public void CD()
    {
       iCAn=true;
    }
}
