using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese2 : MonoBehaviour
{
    public PizzaMaking pizzaMakingScript;
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

        if (collision.gameObject.CompareTag("mushroom"))
        {
            if (!pizzaMakingScript.toppingsAdded.Contains(collision.gameObject.name))
            {
                pizzaMakingScript.toppingsAdded.Add(collision.gameObject.name);
                pizzaMakingScript.mushroomNumber = pizzaMakingScript.mushroomNumber + 1;
                pizzaMakingScript.timerOne = 0f;
            }
        }
    } 
}