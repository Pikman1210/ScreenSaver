using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    public Camera cam;

    public void ChangeBackground (int colorIndex)
    {
        switch (colorIndex)
        {
            case 0: // red
                cam.backgroundColor = new Color32(22, 3, 4, 0);
                PlayerPrefs.SetInt("Color", colorIndex);
                break;
            case 1: // orange
                cam.backgroundColor = new Color32(22, 11, 3, 0);
                PlayerPrefs.SetInt("Color", colorIndex);
                break;
            case 2: // yellow
                cam.backgroundColor = new Color32(22, 3, 3, 0);
                PlayerPrefs.SetInt("Color", colorIndex);
                break;
            case 3: // green
                cam.backgroundColor = new Color32(5, 22, 3, 0);
                PlayerPrefs.SetInt("Color", colorIndex);
                break;
            case 4: // blue
                cam.backgroundColor = new Color32(3, 4, 22, 0);
                PlayerPrefs.SetInt("Color", colorIndex);
                break;
            case 5: // purple
                cam.backgroundColor = new Color32(16, 3, 22, 0);
                PlayerPrefs.SetInt("Color", colorIndex);
                break;
            case 6: // white
                cam.backgroundColor = new Color32(63, 63, 63, 0);
                PlayerPrefs.SetInt("Color", colorIndex);
                break;
            case 7: // black
                cam.backgroundColor = new Color32(0, 0, 0, 0);
                PlayerPrefs.SetInt("Color", colorIndex);
                break;
            default:
                PlayerPrefs.DeleteKey("Color");
                cam.backgroundColor = new Color32(16, 3, 22, 0); // r, g, b, alpha
                break;
        }
    }
}
