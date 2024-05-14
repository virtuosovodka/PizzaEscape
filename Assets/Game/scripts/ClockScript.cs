using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
    public TimeManager tm;
    public Transform minuteHand;
    public Transform hourHand;
    public int hourCode;
    public int minuteCode;
    public string theCode;

    const float hoursToDegrees = 360 / 12, minutesToDegrees = 360 / 60;
    // Start is called before the first frame update
    void Start()
    {
        tm = FindObjectOfType<TimeManager>();
     
        
    }

    // Update is called once per frame
    void Update()
    {
        KeyCode();
        hourHand.rotation = Quaternion.Euler(0, 0, -tm.GetHour() * hoursToDegrees);
        
        minuteHand.rotation = Quaternion.Euler(0, 0, -tm.GetMinutes() * minutesToDegrees);
    }

    public void KeyCode()
    {
        minuteCode = Mathf.FloorToInt(tm.GetMinutes());
        hourCode = Mathf.FloorToInt(tm.GetHour());

        if (hourCode == 0)
        {
            hourCode = 12;
        }
        //print(minuteCode.ToString("00"));
        theCode =(hourCode.ToString("00") + minuteCode.ToString("00"));
        //LSG
        // ToString("00")
    }

}
