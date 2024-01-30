using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoughPuzzle : MonoBehaviour
{
   public GameManager gm;
   public GameObject placemat;
   public TextMeshProUGUI text;
   public float timer = 0.0f;
   private bool onSurface;
   private RigidbodyConstraints _constraints;
        
    // Start is called before the first frame update
    void Start()
    {
        //provide gm with a value (the script "GameManager")
        gm = FindObjectOfType<GameManager>();

        _constraints = this.GetComponent<Rigidbody>().constraints;
    }

    // Update is called once per frame
    void Update()
    {
        
        //add more bags and placemat and then change 1 to however many we want and change in game manager
        if (gm.doughPlacement == 10)
        {
            print("Puzzle solved");
            text.text = "" + gm.doughPlacement;
        }

        if (onSurface && _constraints != RigidbodyConstraints.FreezeAll)
        {
            timer += Time.deltaTime;
            if (timer > .3)
            {
                _constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {

        timer = 0;
        onSurface = true;
      
        //if the object the dough bag collided with is the placemat, add 1 to doughPlacement
        if (other.gameObject == placemat)
        {
            gm.doughPlacement ++;
            this.GetComponent<Transform>().rotation = Quaternion.identity;
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        //if the dough bag collided with any other object keep doughPlacement at its' current value
        else
        {
            gm.doughPlacement = gm.doughPlacement; 
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        onSurface = false;
        //if the dough bag is removed from/ is no longer touching the placemat, subtract 1 from doughPlacement
        if (other.gameObject == placemat)
        {
            gm.doughPlacement --;
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}


