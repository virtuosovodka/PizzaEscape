using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorFire : MonoBehaviour
{
    GameObject particleParent;
    public blowTorch bt;

    // Start is called before the first frame update
    void Start()
    {
        bt = GameObject.FindObjectOfType<blowTorch>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bt.extuingisherOn==true)
        {

        }
    }
}
