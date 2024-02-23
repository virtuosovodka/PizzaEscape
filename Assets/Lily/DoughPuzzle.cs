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
   private Rigidbody rb;
        
    // Start is called before the first frame update
    void Start()
    {
        //provide gm with a value (the script "GameManager")
        gm = FindObjectOfType<GameManager>();

        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + gm.doughPlacement + " " + "" + gm.timer;
        if (onSurface && rb.constraints != RigidbodyConstraints.FreezeAll)
        {
            timer += Time.deltaTime;
            if (timer > .3f)
            {
                rb.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        timer = 0f;
        onSurface = true;
      
        //if the object the dough bag collided with is the placemat, add 1 to doughPlacement
        if (other.gameObject == placemat)// && timer == 0f)
        {
            gm.doughPlacement++;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        onSurface = false;
        
        //if the dough bag is removed from/ is no longer touching the placemat, subtract 1 from doughPlacement
        if (other.gameObject == placemat)
        {
            gm.doughPlacement--;
        }
    }
}


