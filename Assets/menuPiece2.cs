using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPiece2 : MonoBehaviour
{
    public Vector3 endPosition;
    float speed=2;
    public PizzaMaking pizzaMakingScript;
    public DoorKitchen doorKitchen;
    public Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (pizzaMakingScript.pizzasDone)
        {
            doorKitchen.openDoor = true;
            //transform.position = Vector3.SmoothDamp(transform.position, endPosition, ref velocity, smoothTime, speed);
            print("alright");
            transform.position = Vector3.MoveTowards(startPos, endPosition, speed * Time.deltaTime);
            //not even remotely working
        }
    }
}
