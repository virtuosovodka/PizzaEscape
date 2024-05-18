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

    private Level previous;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();

        previous = gm.level;
    }

    void Update()
    {
        if (gm.level != previous)
        {
            if (gm.level == Level.Zero)
            {
                //change to tutorial room
                SceneManager.LoadScene(0);
                previous = Level.Zero;
            }
            else if (gm.level == Level.One)
            {
                //change to kitchen
                //this happens after tutorial scene is complete 
                SceneManager.LoadScene(1);
                previous = Level.One;
            }
            else if (gm.level == Level.Two)
            {
                //changes to cold room
                SceneManager.LoadScene(2);
                previous = Level.Two;
            }
            else if (gm.level == Level.Three)
            {
                //takes you to dining room
                SceneManager.LoadScene(3);
                previous = Level.Three;
            }
            else if (gm.level == Level.Four)
            {
                //takes you to kitchen
                SceneManager.LoadScene(1);
                previous = Level.Four;
                //this happens when the piano is played correctly 
                //You must kill the pizza monster to stop the destruction it will unleash. Find the pieces of the menu for the secret sauce to succeed in your mission.
            } else if (gm.level == Level.Five)
            {
                SceneManager.LoadScene(4);
            }

            gm.ResetLevelClears();
        }
    }
}