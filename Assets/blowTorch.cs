using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blowTorch : MonoBehaviour
{

    public GameObject player;
    public GameObject fire;
    GarlicKnot garlicKnot;
    // Start is called before the first frame update
    void Start()
    {
        fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            print("L key is down");
            fire.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            print("K key is down");
            fire.SetActive(false);
        }

    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("player"))
        {

            transform.parent = player.transform;
            //print("blow torch");

        }
     
    }
}