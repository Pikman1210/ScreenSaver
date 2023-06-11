using UnityEngine;

public class SettingsTextDisable : MonoBehaviour
{
    public GameObject text;
    public GameObject text2;

    public void DisableSettingsText()
    {
        text.SetActive(false);
    }

    public void EnableMouseText()
    {
        text2.SetActive(true);
    }
}
