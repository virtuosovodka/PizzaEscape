using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoughPuzzle : MonoBehaviour
{
   public GameManager gm;
   
   public GameObject placemat;
   //public bool doughPlacement;
        
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        //set doughPlacement to false
        //doughPlacement = false;
    }

    // Update is called once per frame
    void Update()
    {
        //gm.UpdateDoughPlacement(placement);
    }

    private void OnCollisionEnter(Collision other)
    {
        //if the object the dough bag collided with is the placemat, set doughPlacement to true
        if (other.gameObject == placemat)
        {
            gm.doughPlacement = true;
        }
        //if the dough bag collided with any other object keep doughPlacement set to false
        else
        {
            gm.doughPlacement = false; 
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        //if the dough bag is no longer touching the placemat, set doughPlacement to false
        if (other.gameObject == placemat)
        {
            gm.doughPlacement = false;
        }
    }
}


