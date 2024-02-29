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
    private bool start2ndTimer = false;
    private bool start3rdTimer = false;
    private bool start4thTimer = false;
    private bool start5thTimer = false;
    private bool startTimer = false;
    public float fourthTimer;
    public float fifthTimer;
    public float thirdTimer;
    public float forwardTimer;
    public float secondTimer;
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
        startTimer = true;




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
        if (startTimer)
        {
            forwardTimer -= Time.deltaTime;

            if (forwardTimer <= 0)
            {
                print("time's up");
                transform.eulerAngles = new Vector3(0, 270, 0);
                start2ndTimer = true;
                startTimer = false;
                forwardTimer = 4;
            }
        }
        else if (start2ndTimer)
        {
            secondTimer -= Time.deltaTime;

            if (secondTimer <= 0)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                start2ndTimer = false;
                start3rdTimer = true;
                secondTimer = 1;
            }
        }
     
          else if (start3rdTimer)
        {
         thirdTimer -= Time.deltaTime;

          if (thirdTimer <= 0)
          {
              transform.eulerAngles = new Vector3(0, 90, 0);
              start3rdTimer = false;
              start4thTimer = true;
              thirdTimer = 8;
          }
        }
        else if (start4thTimer)
      {
          fourthTimer -= Time.deltaTime;

          if (fourthTimer <= 0)
          {
              transform.eulerAngles = new Vector3(0, 0, 0);
              start4thTimer = false;
              start5thTimer = true;
                fourthTimer = 1;
          }
      }
      //   else if (start3rdTimer)
      //{
      //    thirdTimer -= Time.deltaTime;

      //    if (thirdTimer <= 0)
      //    {
      //        transform.eulerAngles = new Vector3(0, 270, 0);
      //        start3rdTimer = false;
      //        start4thTimer = true;
      //    }
      //}
          else if (start5thTimer)
      {
          fifthTimer -= Time.deltaTime;

          if (fifthTimer <= 0)
          {
              transform.eulerAngles = new Vector3(0, -90, 0);
              start5thTimer = false;
              start2ndTimer = true;
              fifthTimer = 8;
          }
      }
    
        else if (tempPlayer.chasePlayer == true)

        {
            print("garlic knots will chase player");
            start2ndTimer = false;
            start3rdTimer = false;
            start4thTimer = false;
            start5thTimer = false;
            startTimer = false;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.transform.position - transform.position), garlicSpeed * Time.deltaTime);

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, garlicSpeed * Time.deltaTime);
           
        }
        else if (tempPlayer.chasePlayer == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, garlicSpeed * Time.deltaTime);
            Vector3 newRotation = new Vector3(0, 0, 0);
            transform.eulerAngles = newRotation;
            if (Mathf.Abs(Vector3.Distance(transform.position, target)) < .2)
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

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);
    }

    /*private void OnCollisionEnter(Collision other)
    {
       

        if (marching == true)
        {
            

            if( forwardTimer <= 0.0f)
            {
                print("time's up");
                transform.eulerAngles = new Vector3(0, -90, 0);

            }

            
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

   }
}

   } */

}


