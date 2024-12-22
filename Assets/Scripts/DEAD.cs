using UnityEngine.SceneManagement;
using Unity.XR.CoreUtils;
using UnityEngine;

public class DEAD : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<XROrigin>())
        {
            SceneManager.LoadScene("vuSdohli");
        }
    }
}
