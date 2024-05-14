using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPiece2 : MonoBehaviour
{
    public Vector3 endPosition;
    float speed=.1f;
    public PizzaMaking pizzaMakingScript;
    public DoorKitchen doorKitchen;
    Vector3 startPos;
    Rigidbody rb;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
   }

    // Update is called once per frame
    void Update()
    {
        if (pizzaMakingScript.pizzasDone)
        {
            timer -= Time.deltaTime;
            if (timer > 0)
            {


                Vector3 velocity = new Vector3(0, .1f, 0);
                transform.position = Vector3.SmoothDamp(transform.position, endPosition, ref velocity, 2, speed);
                print("alright");
                //transform.position = Vector3.MoveTowards(startPos, endPosition, speed * Time.deltaTime);

                //doorKitchen.openDoor = true;
                //not even remotely working
            }
        }
    }
}
