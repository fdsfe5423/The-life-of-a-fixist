using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using JetBrains.Annotations;

public class fixibord : MonoBehaviour
{
    public bool iFixiboard;
    public bool iFIXI;
    public bool spawnFixi;
    public GameObject point;
    public GameObject zhopaMira;
    public GameObject spawnPoint;
    public GameObject player;
    public ContinuousMoveProviderBase move;
    public GameObject camera;
    public InputActionProperty acrionDropFIXI;
    public InputActionProperty acrionCallFixi;

    private void Update()
    {
        camera = GameObject.Find("Main Camera");
        player = GameObject.Find("Move");
        move = player.GetComponent<ContinuousMoveProviderBase>();
        point = GameObject.Find("PointFixi");
        bool Drop = acrionDropFIXI.action.IsPressed();
        bool Alyo = acrionCallFixi.action.IsPressed();
        if (Drop)
        {
            iFixiboard = false;
            iFIXI = false;
            Invoke("FIXI", 3);
            print("Drop press");
            move.enableFly = false;
            move.moveSpeed = 2;
        }
        if (Alyo)
        {
            if (iFixiboard == false)
            {
                if (spawnFixi == false)
                {
                    iFIXI = true;
                    iFixiboard = false;
                    gameObject.transform.position = spawnPoint.transform.position;
                    Quaternion gameobjRot = gameObject.transform.rotation;
                    gameObject.transform.localEulerAngles = new Vector3(0, camera.transform.localEulerAngles.y - 90, 0);
                }
            }
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
    public void spawnfixi()
    {
        spawnFixi = false;
    }
}
