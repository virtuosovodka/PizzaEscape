using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DoorKitchen : MonoBehaviour
{
    public GameObject door;
    public bool openDoor;
    private bool isAtDoor = false;
    public ClockScript clockScript;
  

    [SerializeField]private TextMeshProUGUI codeText;
    string codeTextValue = "";
    int codeTextValueInt;
    public string doorCode;
    public GameObject codePanel;
    int doorCodeInt;
    int tolerance = 8;

    // Start is called before the first frame update
    void Start()
    {
        clockScript = GameObject.FindObjectOfType<ClockScript>();
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;
        //codeTextValueInt = int.Parse(codeTextValue.Trim());
        //doorCodeInt = int.Parse(doorCode.Trim());

        //print(int.Parse(clockScript.theCode)+int.Parse(codeTextValue));
        //print(codeTextValue);

        if (((int.Parse(clockScript.theCode)+tolerance) >= int.Parse(codeTextValue)&& (int.Parse(clockScript.theCode) - tolerance)<= int.Parse(codeTextValue))) {

            //codeTextValue >= clockScript.theCode.int.Parse -8 && codeTextValue <= clockScript.theCode ++ 8
            //DO THIS NEXT CLASS CONVERT TO INTEGER
            //also figure out the issue with templayer chasing bool
            //its working !!!!
            openDoor = true;
        }

        if(codeTextValue.Length >= 5)
        {
            codeTextValue = "";
        }

        if (openDoor)
        {
            transform.Translate(Vector3.left * 1f * Time.deltaTime);
        }

        if (door.transform.position.z >= 5)
        {
            openDoor = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="player")
        {
            isAtDoor = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isAtDoor = false;
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}