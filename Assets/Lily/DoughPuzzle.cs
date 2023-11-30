using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoughPuzzle : MonoBehaviour
{
    //public GameObject doughBag;
    public GameObject placemat;
    public bool doughPlacement;
        
    // Start is called before the first frame update
    void Start()
    {
        doughPlacement = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (placemat.transform.position == transform.position)
        {
            doughPlacement = true;
        }
        else
        {
            doughPlacement = false;
        }

        print(doughPlacement);*/
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Placemat"))
        {
            doughPlacement = true;
        }
        else
        {
            doughPlacement = false;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Placemat"))
        {
            doughPlacement = false;
        }
    }
}
