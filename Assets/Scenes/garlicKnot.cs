using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicKnot : MonoBehaviour
{
    public LayerMask raycastYes;
    public LayerMask leftPoint;
    public LayerMask rightPoint;
    public GameObject player;
    public float garlicSpeed = 1;
    bool hasRunLeft;
    bool hasRunRight;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10, 1, 3);
        hasRunRight = false;
        hasRunLeft = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);


        //Ray ray = new Ray(transform.position, transform.forward);
        //Debug.DrawRay(transform.position, transform.forward * 10, Color.green, 30);
        //RaycastHit hitData;

        //if (Physics.Raycast(ray, out hitData, 50, rightPoint))
        //{

        //    print("turn");
        //    transform.Translate(Vector3.back * garlicSpeed * Time.deltaTime);
        //    Vector3 rotationToAdd = new Vector3(0, 180, 0);
        //    //if (hasRunRight == false)
        //    //{
        //        transform.Rotate(rotationToAdd);
        //        //hasRunRight = true;
        //    //}

        //}

        //if (Physics.Raycast(ray, out hitData, 50, leftPoint))
        //{
        //    print("turn");
        //    transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);
        //    Vector3 rotationToAdd = new Vector3(0, 180, 0);
        //    //if (hasRunLeft == false)
        //    //{
        //        transform.Rotate(rotationToAdd);
        //        //hasRunLeft = true;
        //    //}
        //}

        //else if (Physics.Raycast(ray, out hitData, 50, raycastYes))
        //{

        //        // The Ray hit something less than 50 Units away,
        //        // It was on the a certain Layer
        //        print("raycast is working");
        //        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, garlicSpeed * Time.deltaTime);

        //}

    }
    private void OnCollisionEnter(Collider other)
    {
        if (other.CompareTag("rightPoint"))
        {
            print("turn");
            // World Rotation
            transform.eulerAngles = new Vector3(0, 180, 0);
            //transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);
 
            
        }
        if (other.CompareTag("leftPoint"))
        {
            print("turn");
            transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);
            //transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (other.CompareTag("torch"))
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, garlicSpeed * Time.deltaTime);
        }
    }
}