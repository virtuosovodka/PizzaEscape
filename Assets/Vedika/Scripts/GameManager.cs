using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //if doughs are placed in right order gets hit make this true
    public bool _isSecondLevel;
    public bool _isThirdLevel;
    public bool _isFirstLevel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
        {
            _isSecondLevel = true;
        }
        else if (Input.GetButtonDown("XRI_Right_PrimaryButton"))
        {
            _isThirdLevel = true;
        }
        else if (Input.GetButtonDown("XRI_Left_SecondaryButton"))
        {
            _isFirstLevel = true;
        }
    }
}
