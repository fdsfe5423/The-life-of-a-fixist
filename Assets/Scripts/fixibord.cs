using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class fixibord : MonoBehaviour
{
    [SerializeField] GameObject fixbord;
    [SerializeField] GameObject fixbordPlayer;
    [SerializeField] DynamicMoveProvider player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<CharacterController>() != null)
        {
            fixbordPlayer.SetActive(!false);
            fixbord.SetActive(false);
            player.enableFly = true;
            player.useGravity = false;
        }
    }
}
