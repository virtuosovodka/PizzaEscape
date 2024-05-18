using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public enum Level
{
    Zero,
    One,
    Two,
    Three,
    Four
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
    //Dining Room
    public bool keyboardPlayed;
    //Pizza Monster
    // public bool makePestoToKill;
    //used to open door in cold room
    public float timer;
    
    

    
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
        else if ((doughPlacement == 12)|| Input.GetButtonDown("XRI_Right_PrimaryButton")) // || Input.GetKey(KeyCode.C)) //and whatever finishes the kitchen level
        {
            level = Level.Three;

            //timer += Time.deltaTime;
        }
        else if (keyboardPlayed)// || Input.GetButtonDown("XRI_Left_SecondaryButton"))
        {
            // makePestoToKill = true;
            level = Level.Four;
        }

        if (pizzaMan != null)
        {
            if (pizzaMan.gameWon)
            {
                SceneManager.LoadScene(4);
            }
        }
        
    }

    public void ResetLevelClears()
    {
        timer = 0;
        tutorialDoorOpen = false; // Level Zero
        kitchenDoor = false; // Level One
        doughPlacement = 0; // Level Two
        keyboardPlayed = false; // Level Three
        // makePestoToKill = false; // Final Level
    }
}
