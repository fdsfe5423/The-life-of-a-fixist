using UnityEngine.InputSystem;
using UnityEngine;
using JetBrains.Annotations;

public class OpenAndSlose : MonoBehaviour
{
    public GameObject UI;
    public bool isOpen;
    public InputActionProperty action;

    private void Update()
    {
        float iNT = action.action.ReadValue<float>();
        if(isOpen)
        {
            UI.SetActive(true);
        }
        else
        {
            UI.SetActive(false);
        }
        if(iNT > 0.7)
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
        }
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "Hand")
        {
            isOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            isOpen = true;
        }
    }
}
