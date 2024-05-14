using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public GameObject hand;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pepperoni"))
        {
            transform.parent = collision.transform;
        }
    }
}

//next clas you need to work on the parenting of the toppings to the poke interactor(if thats what it should be attaching to)
