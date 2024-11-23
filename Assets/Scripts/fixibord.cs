using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System.Runtime.InteropServices;

public class fixibord : MonoBehaviour
{
    [SerializeField] GameObject fixbordPoint;
    [SerializeField] GameObject fixbordPlayer;
    [SerializeField] GameObject player;
    public bool iFixiboard;

    private void Update()
    {
        fixbordPoint = GameObject.Find("PointFixiboard");
        player = GameObject.Find("Move");
        var continiousMoveProvider = player.GetComponent<ContinuousMoveProviderBase>();
        if(iFixiboard)
        {
            fixbordPlayer.SetActive(false);
            fixbordPoint.SetActive(true);
            continiousMoveProvider.enableFly = true;
            continiousMoveProvider.moveSpeed = 1;
        }
        else
        {
            fixbordPlayer.SetActive(true);
            fixbordPoint.SetActive(false);
            continiousMoveProvider.enableFly = true;
            continiousMoveProvider.moveSpeed = 10;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<CharacterController>() != null)
        {
            iFixiboard = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
        {
            iFixiboard = false;
        }
    }
}
