using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        /*
         * Initialize a bag
         * Have objects lying around
         * Make objects grabbable
         * If object gets grabbed and then collides with bag, it becomes part of array
         * array is assigned to bag
         * if bag is collided with, show message that says to press a to see inside
         * when a is pressed, a display shows you what items you have in the bag
         */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("Grabby"))
        {
            text.text = "Touching Bag!";
        }
    }
}
