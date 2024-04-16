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
        if (gm.isSecondLevel)
        {
            //this will take you to the kitchen scene
            //before loading the scene, start timer and rotate door for 1.5 seconds
            if (gm.timer <= 2.5f && gm.doughPlacement == 12)
            {
               //change the y of the door to make it open
               doorHinge.transform.Rotate(0,0,1);
            }
            else if (gm.timer > 2.5f)
            {
                //when timer is 1.5 seconds, the scene changes
                SceneManager.LoadScene(1);
                gm.doughPlacement = 0;
                gm.timer = 0;
            }
        }
        if (gm.isThirdLevel)
        {
            //this will take you to the basement scene
            SceneManager.LoadScene(2);
        }
        if (gm.pizzaMonsterRelease)
        {
            //this happens when the piano is played correctly 
            pizzaMonster.SetActive(true);
            pizzaMonsterText.text = "You must kill the pizza monster to stop the destruction it will unleash blah blah blah. Find the pieces of the menu and make the secret sauce blah blah.";

        }
        if (gm.isFirstLevel)
        {
            //this happens on the beginning 
            SceneManager.LoadScene(0);
        }
        if (gm.isFourthLevel)
        {
            //this happens if the stuff in the basement gets completely
            //it loads the dining room 
            SceneManager.LoadScene(3);
        }
    }
}