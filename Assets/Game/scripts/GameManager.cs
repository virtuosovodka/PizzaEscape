using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public enum Level
{
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //this is how new scenes load
    public Level level = Level.Zero;
    //public TextMeshProUGUI text;
    public PizzaMan pizzaMan;
    //Tutorial Scene
    public bool tutorialDoorOpen;
    //Kitchen
    public bool kitchenDoor;
    //Cold Room
    public int doughPlacement;
    //Basement
    public bool lockerCombo;
    //Dining Room
    public bool keyboardPlayed;
    // Pizza Man defeated
    public bool gameWon = false;
    //used to open door in cold room
    public float timer;

    public Level finalLevel = Level.Five;
    
    

    
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(instance.gameObject);
    }
    
    void Start()
    {
        ResetLevelClears();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XRI_Right_PrimaryButton") && Input.GetButtonDown("XRI_Right_SecondaryButton"))
        {
            //restarts game completely
            level = Level.Zero;
        }
        if (tutorialDoorOpen)// || Input.GetButtonDown("XRI_Left_PrimaryButton") || Input.GetKey(KeyCode.B)) //|| the keypad is pressed
        {
            //tutorial level has been finished, moves on to cold room
            level = Level.One;
        }
        else if (kitchenDoor)// || Input.GetButtonDown("XRI_Right_SecondaryButton") || Input.GetKey(KeyCode.A))
        {
            level = Level.Two;
        }
        else if ((doughPlacement == 12))// || Input.GetKey(KeyCode.C)) //and whatever finishes the kitchen level
        {
            level = Level.Three;

            //timer += Time.deltaTime;
        }
        else if (lockerCombo)
        {
            level = Level.Four;
        }
        else if (keyboardPlayed)// || Input.GetButtonDown("XRI_Left_SecondaryButton"))
        {
            level = Level.Five;
        }

        if (gameWon)
            {
                SceneManager.LoadScene(5);
            }
       
        
    }

    public void ResetLevelClears()
    {
        timer = 0f;
        tutorialDoorOpen = false; // Level Zero
        kitchenDoor = false; // Level One
        doughPlacement = 0; // Level Two
        lockerCombo = false;
        keyboardPlayed = false; // Level Three
        // makePestoToKill = false; // Final Level
    }
}
