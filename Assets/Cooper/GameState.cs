using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameState", menuName = "ScriptableObjects/GameState", order = 0)]
public class GameState : ScriptableObject
{
    public enum Level
    {
        Keyboard, Dough, Door, Fourth
    }

    [SerializeField]
    private Level currentLevel = Level.Keyboard;

    [SerializeField]
    private int doughPlacement = 0;
    public const int correctDoughPlacement = 12;

    [SerializeField]
    private float timer = 0;

    public bool kitchenDoorOpen = false;
    public bool keyboardPlayed = false;
    public bool pizzaMonsterReleased = false;


    public Level CurrentLevel {
        get
        {
            switch (currentLevel)
            {
                case Level.Keyboard:
                    if (keyboardPlayed)
                    {
                        currentLevel = Level.Dough;
                    }
                    break;
                case Level.Dough:
                    if (doughPlacement == correctDoughPlacement)
                    {
                        currentLevel = Level.Door;
                    }
                    break;
                case Level.Door:
                    if (kitchenDoorOpen)
                    {
                        currentLevel = Level.Fourth;
                    }
                    break;
                case Level.Fourth:
                default:
                    break;
            }

            return currentLevel;
        }

        set
        {
            currentLevel = value;
        }
    }
}
