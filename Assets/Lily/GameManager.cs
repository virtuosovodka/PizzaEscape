using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    //Vedika
    public bool isFourthLevel;
    public bool isSecondLevel;
    public bool isThirdLevel;
    public bool isFirstLevel;

    public float timer;
    //public TextMeshProUGUI text;
    
    //Coldroom
    public int doughPlacement;
    
    //Kitchen
    public bool kitchenDoor;
    
    //Dining Room
    public bool keyboardPlayed;

    
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
        timer = 0;
        kitchenDoor = false;
        keyboardPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (doughPlacement == 12 || Input.GetButton("XRI_Right_SecondaryButton") || Input.GetKey(KeyCode.A))
        {
            //delete when done testing
            doughPlacement = 12;
            
            timer += Time.deltaTime;
            isSecondLevel = true;
        }
        else if (keyboardPlayed || Input.GetButtonDown("XRI_Right_PrimaryButton"))
        {
            isThirdLevel = true;
        }
        else if (Input.GetButtonDown("XRI_Left_SecondaryButton"))
        {
            //release the pizza monster
        }
        else if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
        {
            isFourthLevel = true;
        }
        else
        {
            isFirstLevel = isSecondLevel = isThirdLevel = isFourthLevel = false;
        }
    }
}
