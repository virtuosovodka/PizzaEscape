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
    public bool pizzaMonsterRelease;
    //public TextMeshProUGUI text;
    
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
    }

    // Update is called once per frame
    void Update()
    {
        if (doughPlacement == 12 || Input.GetButton("XRI_Right_SecondaryButton") || Input.GetKey(KeyCode.A))
        {
            //kitchen level starts (random cube)
            doughPlacement = 12;
            
            timer += Time.deltaTime;
            isSecondLevel = true;
        }
        else if (kitchenDoor || Input.GetButtonDown("XRI_Right_PrimaryButton")) //and whatever finishes the kitchen level
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
            isFirstLevel = isSecondLevel = isThirdLevel = isFourthLevel = false;
        }
    }
}
