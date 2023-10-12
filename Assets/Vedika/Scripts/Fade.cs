using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    void Start()
    {
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XRI_Left_PrimaryButton") || Input.GetKeyDown("a"))
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.Lerp(Color.blue, Color.red, Time.deltaTime / 1.5f);
        }
    }
}
