using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public GameObject Player;
    public GameObject light;

    public bool lightOn;
    public float buttonCoolDownTimer = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        light.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        buttonCoolDownTimer += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == Player && buttonCoolDownTimer > .5f)
        {
            buttonCoolDownTimer = 0;
            lightOn = !lightOn;
            light.SetActive(lightOn);
        }
    }
}
