/*
 using System;
using System.Collections;
using System.Collections.Generic;
*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    // Start is called before the first frame update
    
    /*
     * FOR GAME:
     * create a script that stores specific booleans
     * test each bool to load a new scene instead of booleans stored locally
     * have same list of build settings on everyone's computers
     * decide camera's position locally within game
     *
     * BUGS:
     * person can keep resetting level again and again
     * can go back to previous levels and next levels
     * everything resets each time scene gets reloaded
     */
    
    private bool _isSecondLevel;
    private bool _isThirdLevel;
    private bool _isFirstLevel;
    public GameObject cube;
    
    void Start()
    {
        cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _isSecondLevel = true;
        }
        else if (Input.GetKeyUp("a"))
        {
            _isThirdLevel = true;
        }
        else if (Input.GetKeyUp("d"))
        {
            _isFirstLevel = true;
        }
        else if (Input.GetKeyUp("c")) //&& in first scene)
        {
            cube.SetActive(true);
        }

        if (_isSecondLevel)
        {
            SceneManager.LoadSceneAsync(1);
        }
        else if (_isThirdLevel)
        {
            SceneManager.LoadSceneAsync(2);
        }
        else if (_isFirstLevel)
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}
