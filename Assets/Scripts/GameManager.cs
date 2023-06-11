using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool settingsOpen = false;
    private bool cursorVisible = true;
    private int color;

    public GameObject settingsMenu;

    void Start()
    {
        Cursor.visible = true;

        color = PlayerPrefs.GetInt("Color");
        FindObjectOfType<BackgroundChanger>().ChangeBackground(color);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && cursorVisible == true)
        {
            cursorVisible = false;
            Cursor.visible = false;
        } else if (Input.GetKeyDown(KeyCode.H) && cursorVisible == false)
        {
            cursorVisible = true;
            Cursor.visible = true;
        }

       if (Input.GetKeyDown(KeyCode.Escape) && settingsOpen == false)
        {
            cursorVisible = true;
            Cursor.visible = true;
            settingsOpen = true;
            settingsMenu.SetActive(true);
        } else if (Input.GetKeyDown(KeyCode.Escape) && settingsOpen == true)
        {
            cursorVisible = true;
            Cursor.visible = true;
            settingsOpen = false;
            settingsMenu.SetActive(false);
        } else
        {
            cursorVisible = true;
            Cursor.visible = true;
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
