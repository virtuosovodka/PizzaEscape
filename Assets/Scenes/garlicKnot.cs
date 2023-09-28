using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garlicKnot : MonoBehaviour
{
    public LayerMask raycastYes;
    public GameObject player;
    public float garlicSpeed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10, 1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward, Color.green);
        RaycastHit hitData;
        if (Physics.Raycast(ray, out hitData, 150, raycastYes))
        {
            // The Ray hit something less than 50 Units away,
            // It was on the a certain Layer
            print("raycast is working");
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, garlicSpeed * Time.deltaTime);
        }
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
