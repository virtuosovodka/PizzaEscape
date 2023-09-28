using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    // Start is called before the first frame update

    private bool _isSecondLevel;
    private bool _isThirdLevel;
    
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

        if (_isSecondLevel)
        {
            SceneManager.LoadSceneAsync(1);
        }
        else if (_isThirdLevel)
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
}
