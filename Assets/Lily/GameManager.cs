using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    //this is how new scenes load
    public bool isFourthLevel;
    public bool isSecondLevel;
    public bool isThirdLevel;
    public bool isFirstLevel;
    public bool isLevelZero;
    public bool pizzaMonsterRelease;
    //public TextMeshProUGUI text;
    
    //Tutorial Scene
    public bool tutorialDoorOpen;
    //Cold Room
    public int doughPlacement;
    //used to open door in cold room 
    public float timer;
    
    //Kitchen
    public bool kitchenDoor;
    
    //Dining Room
    public bool keyboardPlayed;

    
    private void Awake()
    {
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
    
    void Start()
    {
        doughPlacement = 0;
        timer = 0;
        kitchenDoor = false;
        keyboardPlayed = false;
        isLevelZero = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (tutorialDoorOpen || Input.GetButtonDown("XRI_Left_PrimaryButton") || Input.GetKey(KeyCode.B)) //|| the keypad is pressed
        {
            //tutorial level has been finished, moves on to cold room
            isFirstLevel = true;
        }
        else if (doughPlacement == 12 || Input.GetButtonDown("XRI_Right_SecondaryButton") || Input.GetKey(KeyCode.A))
        {
            //kitchen level starts 
            doughPlacement = 12;
            
            timer += Time.deltaTime;
            isSecondLevel = true;
        }
        else if (kitchenDoor || Input.GetButtonDown("XRI_Right_PrimaryButton") || Input.GetKey(KeyCode.C)) //and whatever finishes the kitchen level
        {
            isThirdLevel = true;
        }
        else if (Input.GetButtonDown("XRI_Left_SecondaryButton")) //this is the condition if basement is finished
        {
            isFourthLevel = true;
        }
        else if (keyboardPlayed)// || Input.GetButtonDown("XRI_Left_SecondaryButton"))
        {
            pizzaMonsterRelease = true;
        }
        else
        {
            isFirstLevel = isSecondLevel = isThirdLevel = isFourthLevel = isLevelZero = false;
        }
    }
}
