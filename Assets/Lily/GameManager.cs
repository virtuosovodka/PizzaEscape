using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    //Vedika
    public bool isSecondLevel;
    public bool isThirdLevel;
    public bool isFirstLevel;

    public float timer;
    //public TextMeshProUGUI text;
    
    //Lily
    public int doughPlacement;

    
    private void Awake()
    {
        //text.text = "I exist!";
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(instance.gameObject);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        doughPlacement = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = "" + (doughPlacement);
        //first level opens new scene when ten bags are matched up are however many bags are matched up
        // change this 1 to however there are 
        if (doughPlacement == 10)
        {
            timer = Time.deltaTime;
            isSecondLevel = true;
        }
        else if (Input.GetButtonDown("XRI_Right_PrimaryButton") || Input.GetKey(KeyCode.A))
        {
            isThirdLevel = true;
        }
        else if (Input.GetButtonDown("XRI_Left_SecondaryButton") || Input.GetKey(KeyCode.D))
        {
            isFirstLevel = true;
        }
        else
        {
            isFirstLevel = isSecondLevel = isThirdLevel = false;
        }
    }
}
