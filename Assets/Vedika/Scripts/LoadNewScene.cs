/*
 using System;
using System.Collections;
using System.Collections.Generic;
*/
/*
using System;
using System.Collections;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.XR.OpenXR;

public class LoadNewScene : MonoBehaviour
{
    // Start is called before the first frame update

    /*
     * FOR GAME:
     * create a script that stores specific booleans (game manager for example)
     * test each bool to load a new scene instead of booleans stored locally
     * have same list of build settings on everyone's computers
     * decide camera's position locally within game
     *
     * BUGS:
     * person can keep resetting level again and again
     * can go back to previous levels and next levels
     * everything resets each time scene gets reloaded
     * https://stackoverflow.com/questions/61204192/save-and-load-entire-scene-in-unity
     */
/*

    //public GameManager gm;
    public GameObject planeToBlack, planeToTrans;
    public Color startColor, endColor;
    //bigger the speed, the faster it goes 
    public float speed;

    void Start()
    {
        //_canvasGroupAlpha = canvas.GetComponent<CanvasGroup>().alpha;
        //_startAlpha = canvas.GetComponent<CanvasGroup>().alpha;
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.isSecondLevel)
        {
            StartCoroutine(ChangeColor(planeToBlack, startColor, endColor));
            StartCoroutine(LoadYourSceneAsync(planeToBlack));
            //SceneManager.LoadSceneAsync(1);
        }
        else if (gm.isThirdLevel)
        {
            //SceneManager.LoadSceneAsync(2);
        }
        else if (gm.isFirstLevel)
        {
            //SceneManager.LoadSceneAsync(0);
        }
    }

    IEnumerator LoadYourSceneAsync(GameObject cubeToBlack)
    {
        if (cubeToBlack.GetComponent<MeshRenderer>().material.color == endColor)
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1);

            while (!asyncLoad.isDone)
            {
                yield return null;
            }
        }
    }
    
    public IEnumerator ChangeColor(GameObject cube, Color sColor, Color eColor)
    {
        float tick = 0f;
        while (cube.GetComponent<MeshRenderer>().material.color != eColor)
        {
            tick += Time.deltaTime * speed;
            cube.GetComponent<MeshRenderer>().material.color = Color.Lerp(sColor, eColor, tick);
            yield return null;
        }
    }
}

put in gamemanager
if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
   {
   isSecondLevel = true;
   }
   else if (Input.GetButtonDown("XRI_Right_PrimaryButton"))
   {
   isThirdLevel = true;
   }
   else if (Input.GetButtonDown("XRI_Left_SecondaryButton"))
   {
   isFirstLevel = true;
   }
*/