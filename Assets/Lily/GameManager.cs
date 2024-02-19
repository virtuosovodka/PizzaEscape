using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    //Vedika
    public bool isFourthLevel;
    public bool isSecondLevel;
    public bool isThirdLevel;
    public bool isFirstLevel;

    public float timer;
    //public TextMeshProUGUI text;
    
    //Lily
    public int doughPlacement;

    
    private void Awake()
    {
        //text.text = "I exist!";
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
    
    // Start is called before the first frame update
    void Start()
    {
        doughPlacement = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (doughPlacement == 12)
        {
            isSecondLevel = true;
        }
        else if (Input.GetButtonDown("XRI_Right_PrimaryButton"))
        {
            isThirdLevel = true;
        }
        else if (Input.GetButtonDown("XRI_Left_SecondaryButton"))
        {
            isFirstLevel = true;
        }
        else if (Input.GetButtonDown("XRI_Right_SecondaryButton"))
        {
            isFourthLevel = true;
        }
        else
        {
            isFirstLevel = isSecondLevel = isThirdLevel = isFourthLevel = false;
        }
    }
}
