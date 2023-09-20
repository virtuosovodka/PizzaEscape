using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garlicKnot : MonoBehaviour
{

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

      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("rightPoint"))
        {
            print("turn");
            transform.Translate(Vector3.back * garlicSpeed * Time.deltaTime);
        }
    }
}
