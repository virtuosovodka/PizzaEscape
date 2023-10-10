//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //if doughs are placed in right order gets hit make this true
    public bool isSecondLevel;
    public bool isThirdLevel;
    public bool isFirstLevel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
        {
            isSecondLevel = true;
        }
        else if (Input.GetButtonDown("XRI_Right_PrimaryButton"))
        {
            isThirdLevel = true;
        }
        else if (Input.GetButtonDown("XRI_Left_SecondaryButton"))
        {
            isFirstLevel = true;
        }
    }
}
