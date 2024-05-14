using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public GameManager gm;
    
    //cold room
    public GameObject doorHinge;

    //dining room
    public GameObject pizzaMonster;
    public TextMeshProUGUI pizzaMonsterText;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (gm.isLevelZero)
        {
            SceneManager.LoadScene(0);
        }
        else if (gm.isFirstLevel)
        {
            //this happens after tutorial scene is complete 
            SceneManager.LoadScene(1);
            gm.tutorialDoorOpen = false;
        }
        else if (gm.isSecondLevel)
        {
            //this will take you to the kitchen scene
            //before loading the scene, start timer and rotate door for 1.5 seconds
            SceneManager.LoadScene(2);
            gm.kitchenDoor = false;
        }/*
        else if (gm.isThirdLevel)
        {
            //this will take you to the basement scene
            SceneManager.LoadScene(3);
            gm.kitchenDoor = false;
        }
        */
        else if (gm.isFourthLevel)
        {
            //this happens if the stuff in the basement gets completely
            //it loads the dining room 
            if (gm.timer <= 2.5f && gm.doughPlacement == 12)
            {
                //change the y of the door to make it open
                doorHinge.transform.Rotate(0, 0, 1);
            }
            else if (gm.timer > 2.5f)
            {
                //when timer is 1.5 seconds, the scene changes
                SceneManager.LoadScene(3);
                gm.doughPlacement = 0;
                gm.timer = 0;
            }
        }
        else if (gm.pizzaMonsterRelease)
        {
            //this happens when the piano is played correctly 
            pizzaMonster.SetActive(true);
            pizzaMonsterText.text = "Thank you for playing our game! You successfully made the pizza monster show himself but we have yet to implement the next part of the game.";
            //You must kill the pizza monster to stop the destruction it will unleash. Find the pieces of the menu for the secret sauce to succeed in your mission.
        }
        
    }
}