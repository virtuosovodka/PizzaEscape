//using System.Collections;
//using System.Collections.Generic;

using System;
using UnityEngine;

public class CubeDisappear : MonoBehaviour
{
    public GameObject cube;
    public GameManager gm;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Grabby"))
        {
            gm.doughPlacement = 10;
        }
    }
}
