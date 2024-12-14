using UnityEngine.SceneManagement;
using Unity.XR.CoreUtils;
using UnityEngine;

public class SceneRepairManager : MonoBehaviour
{
    public string name;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<XROrigin>())
        {
            if (PlayerPrefs.GetInt(name) == 0)
            {
                SceneManager.LoadScene(name);
            }
        }
    }
}
