using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garlicKnot : MonoBehaviour
{
    public LayerMask layerMask;
    public float garlicSpeed = 1;
    public GameObject player;
     
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10, 1, 3);

    }


   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);

      

        Ray garlicRay = new Ray(transform.position, transform.forward);
        Debug.DrawRay(garlicRay.origin, garlicRay.direction * 100, Color.green);
        RaycastHit hitData;
          if (Physics.Raycast(garlicRay, out hitData, 100, layerMask, QueryTriggerInteraction.Ignore))
        {
            print("ray is working");
            transform.position = Vector3.MoveTowards(transform.position,player.transform.position,garlicSpeed*Time.deltaTime);
        }
        
          
       
        // Container for hit data


        // Reads the Collider tag

        //collision = hit.point;
    }
      
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("rightPoint"))
        {
            print("turn");
            transform.Translate(Vector3.back * garlicSpeed * Time.deltaTime);
        }
        if (other.CompareTag("leftPoint"))
        {
            print("turn");
            transform.Translate(Vector3.forward* garlicSpeed * Time.deltaTime);
        }

    }
}
