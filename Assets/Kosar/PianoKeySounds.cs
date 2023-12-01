using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoKeySounds : MonoBehaviour
{
    private AudioSource A;
    // Start is called before the first frame update
    void Start()
    {
        
        A = GetComponent<AudioSource>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            A.Play();
        }
        
    }
}
