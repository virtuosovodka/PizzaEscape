/*
 using System;
using System.Collections;
using System.Collections.Generic;
*/

using System;
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

    public GameManager gm;
    //public Canvas canvas;
    //private float _maxAlpha = 1.0f;
    //private float _startAlpha;
    //private float _canvasGroupAlpha;

    void Start()
    {
        //_canvasGroupAlpha = canvas.GetComponent<CanvasGroup>().alpha;
        //_startAlpha = canvas.GetComponent<CanvasGroup>().alpha;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gm.isFirstLevel);

        if (gm.isSecondLevel)
        {
            //_startAlpha = Mathf.MoveTowards(_startAlpha, _maxAlpha, 2.0f * Time.deltaTime);
            SceneManager.LoadSceneAsync(1);
        }
        else if (gm.isThirdLevel)
        {
            SceneManager.LoadSceneAsync(2);
        }
        else if (gm.isFirstLevel)
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}