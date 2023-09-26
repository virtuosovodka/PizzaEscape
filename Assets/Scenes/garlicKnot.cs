using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garlicKnot : MonoBehaviour
{
    public Vector3 collision = Vector3.zero;
    public float garlicSpeed = 1;
    public GameObject lastHit;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10, 1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * garlicSpeed * Time.deltaTime);
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastCommand hit;
        if (Physics.Raycast(ray, out hit, 25)){


            lastHit = hit.transform.gameObject;
            //collision = hit.point;
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
