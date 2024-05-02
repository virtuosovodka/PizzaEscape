using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collided3 : MonoBehaviour
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

        if (collision.gameObject.CompareTag("pineapple"))
        {
            if (!pizzaMakingScript.toppingsAdded.Contains(collision.gameObject.name))
            {
                pizzaMakingScript.toppingsAdded.Add(collision.gameObject.name);
                pizzaMakingScript.pineappleNumber = pizzaMakingScript.pineappleNumber + 1;
                pizzaMakingScript.timerOne = 0f;
            }
        }
        if (collision.gameObject.CompareTag("ham"))
        {
            if (!pizzaMakingScript.toppingsAdded.Contains(collision.gameObject.name))
            {
                pizzaMakingScript.toppingsAdded.Add(collision.gameObject.name);
                pizzaMakingScript.hamNumber = pizzaMakingScript.hamNumber + 1;
                pizzaMakingScript.timerOne = 0f;
            }
        }
    }
}
