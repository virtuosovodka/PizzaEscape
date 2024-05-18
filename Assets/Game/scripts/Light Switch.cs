using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject lights;
    public GameObject text;

    bool lightsOn;

    // Start is called before the first frame update
    void Start()
    {
        lightsOn = true;
        text.SetActive(false);
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            if (lightsOn)
            {
                lights.SetActive(false);
                text.SetActive(true);
                lightsOn = false;
            } else
            {
                lights.SetActive(true);
                text.SetActive(false);
                lightsOn = true;
            }
        }
    }
}
