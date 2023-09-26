using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    // Start is called before the first frame update

    private GameManager gm;
    private bool _isSecondLevel;
    
    void Start()
    {
        SceneManager.LoadSceneAsync(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !_isSecondLevel)
        {
            _isSecondLevel = true;
            SceneManager.LoadSceneAsync(1);
        }
        Debug.Log(_isSecondLevel);
    }
}
