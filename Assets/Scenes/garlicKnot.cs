using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicKnot : MonoBehaviour
{
    public LayerMask raycastYes;
    public LayerMask leftPoint;
    public LayerMask rightPoint;
    public GameObject player;
    TempPlayer tempPlayer;
    public float garlicSpeed = .5f;
    bool hasRunLeft;
    bool hasRunRight;
    private Rigidbody rb;
    public float rotationSpeed = 5;
    [SerializeField] private Vector3 target = new Vector3(20, .5f, .25f);
    bool marching;
    // private Vector3 mytransform = target;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(20, .5f, .25f);
        tempPlayer = player.GetComponent<TempPlayer>();
        tempPlayer.chasePlayer = false;
        rb = GetComponent<Rigidbody>();
       marching = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);


        if (tempPlayer.chasePlayer == true)
        
            {
                print("garlic knots will chase player");
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.transform.position - transform.position), garlicSpeed * Time.deltaTime);
                transform.position += transform.forward * Time.deltaTime * garlicSpeed;
            // transform.position = Vector3.MoveTowards(transform.position, player.transform.position, garlicSpeed * Time.deltaTime);
            marching = false;
            }
            else if (tempPlayer.chasePlayer == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, garlicSpeed * Time.deltaTime);
            marching = true;
        }






        /*   Ray ray = new Ray(transform.position, new Vector3(-4,0,0));
         Debug.DrawRay(transform.position, new Vector3(-4, 0, 0), Color.green, 30);
         RaycastHit hitData;

       if (Physics.Raycast(ray, out hitData, 50, rightPoint))
         {

             print("turn");
             transform.Translate(Vector3.back * garlicSpeed * Time.deltaTime);
             Vector3 rotationToAdd = new Vector3(0, 180, 0);
             //if (hasRunRight == false)
             //{
             transform.Rotate(rotationToAdd);
             //hasRunRight = true;
             //}

         }

         if (Physics.Raycast(ray, out hitData, 50, leftPoint))
         {
             print("turn");
             transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);
             Vector3 rotationToAdd = new Vector3(0, 180, 0);
             //if (hasRunLeft == false)
             //{
             transform.Rotate(rotationToAdd);
             //hasRunLeft = true;
             //}
         }
       
        if (Physics.Raycast(ray, out hitData, 50, raycastYes))
        {

            // The Ray hit something less than 50 Units away,
            // It was on the a certain Layer
            print("raycast is working");
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, garlicSpeed * Time.deltaTime);

        }
         */
    }



    private void OnCollisionEnter(Collision other)
    {

        if (marching == true)
        {

            if (other.gameObject.CompareTag("rightPoint"))
            {
                print("turn");
                // World Rotation
                transform.eulerAngles = new Vector3(0, 180, 0);

                //garlicSpeed = -garlicSpeed;
                //transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);
               

            }
            else if (other.gameObject.CompareTag("leftPoint"))
            {
                print("turn");
                transform.eulerAngles = new Vector3(0, 0, 0);

                //garlicSpeed = -garlicSpeed;
                //transform.eulerAngles = new Vector3(0, 0, 0);
               
            }
            /*else if (other.gameObject.CompareTag("torch"))
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, garlicSpeed * Time.deltaTime);

           }*/
        }
    }

}
/*
private void OnCollisionEnter(Collision other)
    {
         if (other.gameObject.CompareTag("rightPoint"))
         {
             print("turn");
             // World Rotation
             transform.eulerAngles = new Vector3(0, 180, 0);

            //garlicSpeed = -garlicSpeed;
            //transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);
            marching = true;


        }
         else if (other.gameObject.CompareTag("leftPoint"))
         {
             print("turn");
            transform.eulerAngles = new Vector3(0, 0, 0);

            //garlicSpeed = -garlicSpeed;
            //transform.eulerAngles = new Vector3(0, 0, 0);
            marching = true;
        }
         /*else if (other.gameObject.CompareTag("torch"))
         {
             transform.position = Vector3.MoveTowards(transform.position, player.transform.position, garlicSpeed * Time.deltaTime);
            
        }*/
 //   } 
//}