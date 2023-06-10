using UnityEngine;

public class SettingsTextDisable : MonoBehaviour
{
    public GameObject text;

    public void DisableSettingsText()
    {
        text.SetActive(false);
    }
}
