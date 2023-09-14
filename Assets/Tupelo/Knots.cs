using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knots : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))transform.position += Vector3.forward;
        // vector 3 is shrthand for (0,0,1)
                
    }
}
