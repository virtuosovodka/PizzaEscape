using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;

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
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if(gameObject.mainObject.CompareTag(5)){
        //doorKitchen.addingDig("5")
    }
}
