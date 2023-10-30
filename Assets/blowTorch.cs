using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blowTorch : MonoBehaviour
{

    public GameObject player;
    public GameObject fire;
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
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("torch")) {

            transform.parent = player.transform;
            //print("blow torch");

        }
    }
}