using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public bool makePestoToKill;
    //public TextMeshProUGUI text;
    public PizzaMan pizzaMan;
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
        if (Input.GetButtonDown("XRI_Right_PrimaryButton") && Input.GetButtonDown("XRI_Right_SecondaryButton"))
        {
            //restarts game completely 
            SceneManager.LoadScene(0);
        }
        if (tutorialDoorOpen)// || Input.GetButtonDown("XRI_Left_PrimaryButton") || Input.GetKey(KeyCode.B)) //|| the keypad is pressed
        {
            //tutorial level has been finished, moves on to cold room
            isFirstLevel = true;
        }
        else if (kitchenDoor)// || Input.GetButtonDown("XRI_Right_SecondaryButton") || Input.GetKey(KeyCode.A))
        {
            isSecondLevel = true;
        }
        else if ((doughPlacement == 12))// || Input.GetButtonDown("XRI_Right_PrimaryButton")) // || Input.GetKey(KeyCode.C)) //and whatever finishes the kitchen level
        {
            doughPlacement = 12;
            SceneManager.LoadScene(3);
            isFourthLevel = true;
            doughPlacement = 0;

            //timer += Time.deltaTime;
        }
        else if (keyboardPlayed)// || Input.GetButtonDown("XRI_Left_SecondaryButton"))
        {
            makePestoToKill = true;
        }
        else
        {
            isFirstLevel = isSecondLevel = isThirdLevel = isFourthLevel = isLevelZero = false;
        }

        if (pizzaMan.gameWon)
        {
            SceneManager.LoadScene(4);
        }
    }
}
