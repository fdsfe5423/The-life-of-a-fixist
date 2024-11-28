using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class fixibord : MonoBehaviour
{
    public bool iFixiboard;
    public bool iFIXI;
    public GameObject point;
    public GameObject player;
    public ContinuousMoveProviderBase move;
    public GameObject camera;
    public InputActionProperty acrionDropFIXI;

    private void Update()
    {
        camera = GameObject.Find("Main Camera");
        player = GameObject.Find("Move");
        move = player.GetComponent<ContinuousMoveProviderBase>();
        point = GameObject.Find("PointFixi");
        float Drop = acrionDropFIXI.action.ReadValue<float>();
            if(Drop > 0.8)
            {
                iFixiboard = false;
                iFIXI = false;
                Invoke("FIXI", 1);
            }
        if(iFixiboard)
        {
            gameObject.transform.position = point.transform.position;
            Quaternion gameobjRot = gameObject.transform.localRotation;
            gameObject.transform.localEulerAngles = new Vector3(0, camera.transform.localEulerAngles.y, 0);
            move.enableFly = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<CharacterController>() != null && !iFixiboard && iFIXI)
        {
            
            iFixiboard = true;
            move.moveSpeed *= 3;
        }
    }
    public void FIXI()
    {
        iFIXI = true;
    }
}
