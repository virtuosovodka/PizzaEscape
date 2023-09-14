using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoughPuzzle : MonoBehaviour
{
    public GameObject doughBag;
    public GameObject placemat;
    public bool doughPlacement;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == doughBag)
        {
            doughPlacement = true;
        }
        else
        {
            doughPlacement = false;
        }
    }
}
