using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private SceneLoadingManager _sceneManager;
    private bool _isSecondLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        _isSecondLevel = false;
        FetchComponents();
        Fridge();
    }

    void FetchComponents()
    {
        _sceneManager = GameObject.Find("SceneManager").GetComponent<SceneLoadingManager>();
        if (_sceneManager != null)
        {
            Debug.Log("SceneManager is not null.");
        }
    }

    public void Fridge()
    {
        //Fridge Logic
        if (!_isSecondLevel)
        {
            _sceneManager.LoadGame(0);
        }
        
    }
    
    public void Kitchen()
    {
        //Kitchen Logic
        if (_isSecondLevel)
        {
            _sceneManager.LoadGame(1);
        }
    }

    public void Basement()
    {
        //Basement Logic
    }

    public void DiningRoom()
    {
        //Dining Room Logic
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
