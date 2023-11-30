using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    GarlicKnot garlicKnot;
    public GameObject garlic;

    // Start is called before the first frame update
    void Start()
    {
        garlicKnot = garlic.GetComponent<GarlicKnot>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("garlicKnot"))
        {
            print("garlic should burn rn");
            garlicKnot.burn = true;
        }
    }


}
