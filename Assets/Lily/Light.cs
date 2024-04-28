using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    // 'light' is already a type, changed to 'spotLight' to prevent naming conflict
    public GameObject spotLight;
    public GameObject lockerCombo;

    public bool spotLightIsOn;
    public float buttonCoolDownTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        // On start turn the spotLight on and the "Pizza monster is scared of the dark" textMesh off
        spotLightIsOn = true;
        spotLight.SetActive(true);

        lockerCombo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // The button cool down timer makes it so the button will only be "activated" once when touched
        buttonCoolDownTimer += Time.deltaTime;

        spotLight.SetActive(spotLightIsOn);
        lockerCombo.SetActive(!spotLightIsOn);
    }

    private void OnTriggerEnter(Collider other)
    {
        // If the object touching the spotLight switch (object this script is attached to) is the player and the button
        // cool down timer is greater than 0.5 frames, set the button cool down timer to zero, change the value of 
        // spotLightIsOn. Then change whether or not the spotLight is on based on the value of spotLightIsOn, make lockerCombo.SetActive
        // the opposite of spotLightIsOn.

        if (other.gameObject.CompareTag("player") && buttonCoolDownTimer > .5f)
        {
            buttonCoolDownTimer = 0;
            spotLightIsOn = !spotLightIsOn;
        }
    }
}
