using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public TextMeshProUGUI text;
    
    public GameObject cubeOne;
    public GameObject cubeTwo;
    public GameObject cubeThree;
    public GameObject cubeFour;
    public ArrayList cubes = new ArrayList();
    
    private int _arrayPlace;
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
        text.text = "" + cubes.Count;

        if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
        {
            cubeOne.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision collider)
    {
        //get name of object colliding and then push to array
        if (collider.gameObject.CompareTag("Grabby"))
        {
            
        } 
        else if (collider.gameObject.name == "Object (1)")
        {
            cubeTwo.SetActive(false);
            cubes.Add(cubeTwo);
        }
        else if (collider.gameObject.name == "Object (2)")
        {
            cubeThree.SetActive(false);
            cubes.Add(cubeThree);
        }
        else if (collider.gameObject.name == "Object (3)")
        {
            cubes.Add(cubeFour);
            cubeFour.SetActive(false);
        }
    }
}
