using System;
using System.Collections;
using System.Collections.Generic;
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
     */
    
    private bool _isSecondLevel;
    private bool _isThirdLevel;
    private bool _isFirstLevel;
    private int count;
    
    void Start()
    {
        //SceneManager.LoadSceneAsync(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _isSecondLevel = true;
        }
        else if (Input.GetKey("a"))
        {
            _isThirdLevel = true;
        }
        else if (Input.GetKey("d"))
        {
            _isFirstLevel = true;
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
