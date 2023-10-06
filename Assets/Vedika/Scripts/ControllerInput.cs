using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControllerInput : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
        {
            text.text = "Button X pressed";
        }
        else if (Input.GetButtonDown("XRI_Left_SecondaryButton"))
        {
            text.text = "Button Y pressed";
        } 
        else if (Input.GetButtonDown("XRI_Right_SecondaryButton"))
        {
            text.text = "Button B pressed";
        }
        else if (Input.GetButtonDown("XRI_Right_PrimaryButton"))
        {
            text.text = "Button A pressed";
        }
        else if (Input.GetButtonDown("XRI_Left_TriggerButton"))
        {
            text.text = "Left Trigger pressed";
        }
        else if (Input.GetButtonDown("XRI_Right_TriggerButton"))
        {
            text.text = "Right Trigger pressed";
        }
        else if (Input.GetButtonDown("XRI_Left_GripButton"))
        {
            text.text = "Left Grip pressed";
        }
        else if (Input.GetButtonDown("XRI_Right_GripButton"))
        {
            text.text = "Right Grip pressed";
        }
    }
}
