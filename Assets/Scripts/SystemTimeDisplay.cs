using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SystemTimeDisplay : MonoBehaviour
{

    public TextMeshProUGUI text;

    private int hour;
    private int minute;
    private int second;

    void Start()
    {
        
    }

    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;
        second = System.DateTime.Now.Second;
        text.SetText(hour + ":" + minute + ":" + second);
    }
}
