using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public GameObject light;
    public GameObject lockerCombo;

    public bool lightOn;
    public float buttonCoolDownTimer = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        //On start turn the light on and the "Pizza monster is scared of the dark" text off
        lightOn = true;
        light.SetActive(true);
        lockerCombo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //The button cool down timer makes it so the button will only be "activated" once when touched
        buttonCoolDownTimer += Time.deltaTime;
        
        light.SetActive(lightOn);
        lockerCombo.SetActive(!lightOn);
    }

    private void OnTriggerEnter(Collider other)
    {
        //If the object touching the light switch (object this script is attached to) is the player and the button
        //cool down timer is greater than 0.5 frames, set the button cool down timer to zero, change the value of 
        //lightOn. Then change whether or not the light is on based on the value of lightOn, make lockerCombo.SetActive
        //the opposite of lightOn.
        if (other.gameObject.CompareTag("player") && buttonCoolDownTimer > .5f)
        {
            buttonCoolDownTimer = 0;
            lightOn = !lightOn;
            
        }
    }
}
