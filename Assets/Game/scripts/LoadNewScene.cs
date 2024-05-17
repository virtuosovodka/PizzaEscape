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
            //change to tutorial room
            SceneManager.LoadScene(0);
        }
        else if (gm.isFirstLevel)
        {
            //change to kitchen
            //this happens after tutorial scene is complete 
            SceneManager.LoadScene(1);
            gm.tutorialDoorOpen = false;
        }
        else if (gm.isSecondLevel)
        {
            //changes to cold room
            SceneManager.LoadScene(2);
            gm.kitchenDoor = false;
        }
        else if (gm.isThirdLevel)
        {
            //takes you to dining room
            SceneManager.LoadScene(3);
            gm.doughPlacement = 0;
        }
        else if (gm.makePestoToKill)
        {
            //takes you to kitchen
            SceneManager.LoadScene(1);
            //this happens when the piano is played correctly 
            //You must kill the pizza monster to stop the destruction it will unleash. Find the pieces of the menu for the secret sauce to succeed in your mission.
        }
    }
}