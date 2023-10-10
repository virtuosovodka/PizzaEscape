//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CubeDisappear : MonoBehaviour
{
    public GameObject cube;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XRI_Right_SecondaryButton"))
        {
            cube.SetActive(false);
        }
    }
}
