using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SystemTimeDisplay : MonoBehaviour
{

    public TextMeshProUGUI timeText;
    public TextMeshProUGUI dateText;

    private int hour;
    private int minute;
    private int second;

    private int month;
    private int day;
    private int year;

    void Start()
    {
        month = System.DateTime.Now.Month;
        day = System.DateTime.Now.Day;
        year = System.DateTime.Now.Year;
    }

    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;
        second = System.DateTime.Now.Second;

        if (second < 10 && minute < 10)
        {
            timeText.SetText(hour + ":0" + minute + ":0" + second);
        } else if (minute < 10)
        {
            timeText.SetText(hour + ":0" + minute + ":" + second);
        } else if (second < 10)
        {
            timeText.SetText(hour + ":" + minute + ":0" + second);
        } else
        {
            timeText.SetText(hour + ":" + minute + ":" + second);
        }

        if (day < 10 && month < 10)
        {
            dateText.SetText("0" + month + "-0" + day + "-" + year);
        }
        else if (month < 10)
        {
            dateText.SetText("0" + month + "-" + day + "-" + year);
        }
        else if (day < 10)
        {
            dateText.SetText(month + "-0" + day + "-" + year);
        }
        else
        {
            dateText.SetText(month + "-" + day + "-" + year);
        }
    }
}
