using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fade : MonoBehaviour
{
    /*
     * fade from transparent to black in new scene
     * implement this in all other scenes
     * make it go slower
     */
    // Start is called before the first frame update
    public GameObject cube;
    public Color startColor, endColor;
    //bigger the speed, the faster it goes 
    public float speed;
    
    void Start()
    {
        cube.GetComponent<MeshRenderer>().material.color = startColor;
        //StartCoroutine(ChangeColor());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(ChangeColor());
        }
    }

    public IEnumerator ChangeColor()
    {
        float tick = 0f;
        while (cube.GetComponent<MeshRenderer>().material.color != endColor)
        {
            tick += Time.deltaTime * speed;
            cube.GetComponent<MeshRenderer>().material.color = Color.Lerp(startColor, endColor, tick);
            yield return null;
        }
    }
}
