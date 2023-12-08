using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    public const int hoursInDay = 24, minutesInHour = 60;
    public float dayDuration = 43200f;
    float currentTime = 0f;
    float totalTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        currentTime = totalTime % dayDuration;
    }

    public float GetHour()
    {
        return currentTime * hoursInDay / dayDuration;
    }

    public float GetMinutes()
    {
        return (currentTime * hoursInDay * minutesInHour / dayDuration) % minutesInHour;
    }

    public string Clock24Hours()
    {
        return Mathf.FloorToInt(GetHour()).ToString("00") + ":" + Mathf.FloorToInt(GetMinutes()).ToString("00");
    }

    public string Clock12Hours()
    {
        int hour = Mathf.FloorToInt(GetHour());
        int minutes = Mathf.FloorToInt(GetMinutes());
        string abbreviation = "AM";

        if ( hour >= 12)
        {
            abbreviation = "PM";
            hour -= 12;
        }

        if (hour == 0)
        {
            hour = 12;
        }

        return hour.ToString("00") + ":" + minutes.ToString("00") + " " + abbreviation;
    }
}
