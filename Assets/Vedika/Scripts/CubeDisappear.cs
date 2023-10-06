using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDisappear : MonoBehaviour
{
    public GameObject cube;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XRI_Right_SecondaryButton"))
        {
            cube.SetActive(false);
        }
    }
}
