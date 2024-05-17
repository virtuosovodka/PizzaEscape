using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoughPuzzle : MonoBehaviour
{
    private static int numberOfShelves = 3;
    private static int cansPerShelf = 4;

    private static string[,] shelfAssignments = {
        { "Pepperoni", "Salami", "Chicken", "Sausage" },
        { "Pineapple", "Olives", "Mushrooms", "Tomatoes" },
        { "Gorgonzola", "Parmesan", "Ricotta", "Mozzarella" } };

    private static int[] cansOnEachShelf = new int[numberOfShelves];

    public GameManager gm;
    public float timer = 0.0f;
    private bool onSurface;
    private Rigidbody rb;

    private int correctShelf;
    private string shelfTag;

    private IngredientsCorrect ic;
    
    // Start is called before the first frame update
    void Start()
    {
        //provide gm with a value (the script "GameManager")
        gm = FindObjectOfType<GameManager>();
        ic = FindObjectOfType<IngredientsCorrect>();

        rb = GetComponent<Rigidbody>();

        for(int shelfNum = 0; shelfNum < numberOfShelves; shelfNum++)
        {
            for(int canNum = 0; canNum < cansPerShelf; canNum++)
            {
                if(gameObject.name == shelfAssignments[shelfNum, canNum])
                {
                    correctShelf = shelfNum;
                    shelfTag = "Shelf" + (shelfNum + 1).ToString();
                }
            }
        }

        if (shelfTag == "")
        {
            Debug.LogWarning("Ingredient Can name " + gameObject.name + " not found in shelf assignment list.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = "" + gm.doughPlacement + " " + "" + gm.timer;
        if (onSurface && rb.constraints != RigidbodyConstraints.FreezeAll)
        {
            timer += Time.deltaTime;
            if (timer > .3f)
            {
                rb.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        timer = 0f;
        onSurface = true;
      
        //if the object the dough bag collided with is the placemat, add 1 to doughPlacement
        if (other.gameObject.CompareTag(shelfTag)) // && timer == 0f)
        {
            cansOnEachShelf[correctShelf]++;
            gm.doughPlacement++;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        onSurface = false;
        
        //if the dough bag is removed from/ is no longer touching the placemat, subtract 1 from doughPlacement
        if (other.gameObject.CompareTag(shelfTag))
        {
            cansOnEachShelf[correctShelf]--;
            gm.doughPlacement--;
        }
    }

    private void UpdateIndicators()
    {
        for(int i = 0; i < numberOfShelves; i++)
        {
            if(cansOnEachShelf[i] == cansPerShelf)
            {

            }
        }
    }
}


