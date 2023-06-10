using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool settingsOpen = false;
    public GameObject settingsMenu;

    // public Camera cam;
    void Start()
    {
        // cam.backgroundColor = 3;
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape) && settingsOpen == false)
        {
            settingsOpen = true;
            settingsMenu.SetActive(true);
            Debug.Log("Settings Open");
        } else if (Input.GetKeyDown(KeyCode.Escape) && settingsOpen == true)
        {
            settingsOpen = false;
            settingsMenu.SetActive(false);
            Debug.Log("Settings Closed");
        }
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
