using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    //public GameObject button1;
    //public GameObject button2;
    //public GameObject button3;
    //public GameObject button4;
    //public GameObject button5;
    //public GameObject button6;
    //public GameObject button7;
    //public GameObject button8;
    //public GameObject button9;
    //public GameObject button0;

    public GameObject mainObject;

    public DoorKitchen doorKitchen;

    // Start is called before the first frame update
    void Start()
    {
        doorKitchen = GameObject.FindObjectOfType<DoorKitchen>();
    }

    // Update is called once per frame
    void Update()
    {
        //next class you need to figure out why the trigger is not working in VR, because it works with the player cube. Also figure out how to keep the cubes stationary when touched, and why one cubes marching bool doesnt work when player cube comes onto pltform.
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            if (mainObject.tag == "0")
            {
                doorKitchen.AddDigit("0");
               
                mainObject.SetActive(false);
            }
            if (mainObject.tag == "1")
            {
                doorKitchen.AddDigit("1");

                mainObject.SetActive(false);
            }
            if (mainObject.tag == "2")
            {
                doorKitchen.AddDigit("2");

                mainObject.SetActive(false);
            }
            if (mainObject.tag == "3")
            {
                doorKitchen.AddDigit("3");

                mainObject.SetActive(false);
            }
            if (mainObject.tag == "4")
            {
                doorKitchen.AddDigit("4");

                mainObject.SetActive(false);
            }
            if (mainObject.tag == "5")
            {
                doorKitchen.AddDigit("5");

                mainObject.SetActive(false);
            }
            if (mainObject.tag == "6")
            {
                doorKitchen.AddDigit("6");

                mainObject.SetActive(false);
            }
            if (mainObject.tag == "7")
            {
                doorKitchen.AddDigit("7");

                mainObject.SetActive(false);
            }
            if (mainObject.tag == "8")
            {
                doorKitchen.AddDigit("8");

                mainObject.SetActive(false);
            }
            if (mainObject.tag == "8")
            {
                doorKitchen.AddDigit("8");

                mainObject.SetActive(false);
            }
            else if (mainObject.tag == "9")
            {
                doorKitchen.AddDigit("9");

                mainObject.SetActive(false);
            }
        }
    }
}
