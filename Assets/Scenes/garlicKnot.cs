using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicKnot : MonoBehaviour
{
    public GameObject garlicKnot;
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
    [SerializeField] private Vector3 target;
    public bool marching;
    public GameObject fire;
    public bool burn;
    public float forwardTimer = 2.0f;
    // private Vector3 mytransform = target;rec

    //color changing

   
    //float ombreTime = 5f;

   

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
        tempPlayer = player.GetComponent<TempPlayer>();
        tempPlayer.chasePlayer = false;
        rb = GetComponent<Rigidbody>();
       marching = true;
        burn = false;
        


     

        garlicKnot.GetComponent<Renderer>().material.color = Color.blue;
        //garlicKnotRenderer.material.SetColor("_Color", Color.red);


    }

    // Update is called once per frame
    void Update()
    {

        if (burn)
        {
            garlicKnot.GetComponent<Renderer>().material.color = Color.red;
            garlicSpeed = .2f;
        }

        if (marching)
        {


            transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);
        }

    else if (tempPlayer.chasePlayer == true)

            {
               // print("garlic knots will chase player");
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.transform.position - transform.position), garlicSpeed * Time.deltaTime);

                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, garlicSpeed * Time.deltaTime);
            }
    else if (tempPlayer.chasePlayer == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, target, garlicSpeed * Time.deltaTime);
                Vector3 newRotation = new Vector3(0, 0, 0);
                transform.eulerAngles = newRotation;
                if (Mathf.Abs(Vector3.Distance(transform.position, target))<.1)
                {
                    marching = true;
                }
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
            forwardTimer -= Time.deltaTime;

            if( forwardTimer <= 0.0f)
            {
                transform.eulerAngles = new Vector3(0, -90, 0);

            }

            /*
            if (other.gameObject.CompareTag("rightPoint") )
            {
                //print("turn");
                // World Rotation
                transform.eulerAngles = new Vector3(0, 180, 0);

                //garlicSpeed = -garlicSpeed;
                //transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);
               

            }
            else if (other.gameObject.CompareTag("leftPoint"))
            {
                //print("turn");
                transform.eulerAngles = new Vector3(0, 0, 0);

                //garlicSpeed = -garlicSpeed;
                //transform.eulerAngles = new Vector3(0, 0, 0);
               
            }
            
            */
            /*else if (other.gameObject.CompareTag("torch"))
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, garlicSpeed * Time.deltaTime);

           }*/
        }

    }

}


