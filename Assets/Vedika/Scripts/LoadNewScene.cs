using System;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.XR.OpenXR;

public class LoadNewScene : MonoBehaviour
{
    public GameManager gm;
    
    //cold room
    public GameObject doorHinge;

    //dining room
    public GameObject pizzaMonster;
    public TextMeshProUGUI pizzaMonsterText;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.isSecondLevel)
        {
            //before loading the scene, start timer and rotate door for 1.5 seconds
            if (gm.timer <= 2.5f && gm.doughPlacement == 12)
            {
               //change the y of the door to make it open
               doorHinge.transform.Rotate(0,0,1);
            }
            else if (gm.timer > 2.5f)
            {
                //when timer is 1.5 seconds, the scene changes
                SceneManager.LoadScene(1);
                gm.doughPlacement = 0;
                gm.timer = 0;
            }
        }
        if (gm.isThirdLevel)
        {
            //release the pizza monster
            SceneManager.LoadScene(2);
            /*
            if (gm.timer <= 2.5f && gm.keyboardPlayed)
            {
                //change the y of the door to make it open
                doorHinge.transform.Rotate(0,0,1);
            }
            else if (gm.timer > 2.5f)
            {
                //when timer is 1.5 seconds, the scene changes
                SceneManager.LoadScene(2);
                gm.keyboardPlayed = false;
                gm.timer = 0;
            }*/
        }
        if (gm.pizzaMonsterRelease)
        {
            pizzaMonster.SetActive(true);
            pizzaMonsterText.text = "You must kill the pizza monster to stop the destruction it will unleash blah blah blah. Find the pieces of the menu and make the secret sauce blah blah.";

        }
        if (gm.isFirstLevel)
        {
            SceneManager.LoadScene(0);
        }
        if (gm.isFourthLevel)
        {
            SceneManager.LoadScene(3);
        }
    }
}