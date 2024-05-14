using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{

    public GameObject fireFlame;
    public GameObject spout;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("extuingisher");
        if (other.gameObject.CompareTag("extuinguisher"))
        {
            print("flame is colliding");
            fireFlame.SetActive(false);
            spout.SetActive(false);
        }
    }
}
