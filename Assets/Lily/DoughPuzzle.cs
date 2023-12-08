using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoughPuzzle : MonoBehaviour
{
   public GameManager gm;
   
   public GameObject placemat;
        
    // Start is called before the first frame update
    void Start()
    {
        //provide gm with a value (the script "GameManager")
        gm = FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gm.doughPlacement == 2)
        {
            print("Puzzle solved");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        //if the object the dough bag collided with is the placemat, add 1 to doughPlacement
        if (other.gameObject == placemat)
        {
            gm.doughPlacement ++;
        }
        //if the dough bag collided with any other object keep doughPlacement at its' current value
        else
        {
            gm.doughPlacement = gm.doughPlacement; 
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        //if the dough bag is removed from/ is no longer touching the placemat, subtract 1 from doughPlacement
        if (other.gameObject == placemat)
        {
            gm.doughPlacement --;
        }
    }
}


