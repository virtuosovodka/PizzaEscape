using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using TMPro;
public class DoorKitchen : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    private bool isAtDoor = false;
    public ClockScript clockScript;
    public GameObject button1;
    [SerializeField]private TextMeshProUGUI codeText;
    public string codeTextValue = "";
    int codeTextValueInt;
    public string doorCode;
    public GameObject codePanel;
    int doorCodeInt;
    int tolerance = 8;
    public bool addingDig;
    Rigidbody doorRigid1;
    Rigidbody doorRigid2;
    public bool freezePos = true;
    public bool freezeOthers = true;
    public GameObject doorRotate1;
    public GameObject doorRotate2;
    float lerpDuration = .0f;
    float speed = .002f;
    bool rotating;
    public GameManager gm;
    float swingTime = 0f;



    // Start is called before the first frame update
    void Start()
    {
        clockScript = GameObject.FindObjectOfType<ClockScript>();
        //Debug.Log(clockScript);
        gm = FindObjectOfType<GameManager>();
        //addingDig = false;
        doorRigid1 = door1.GetComponent<Rigidbody>();
        doorRigid2 = door2.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        doorRigid1.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
        doorRigid2.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
        while (gm.openDoor)
        {
            swingTime += Time.deltaTime;
            doorRigid1.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
            doorRigid2.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
            rotating = true;
            if (rotating)
            {
                Quaternion startRotation = doorRotate1.transform.rotation;
                Quaternion startRotation2 = doorRotate2.transform.rotation;
                Quaternion targetRotation = doorRotate1.transform.rotation * Quaternion.Euler(0, -90, 0);
                Quaternion targetRotation2 = doorRotate2.transform.rotation * Quaternion.Euler(0, 90, 0);
                doorRotate1.transform.rotation = Quaternion.Lerp(startRotation, targetRotation, lerpDuration * speed);
                doorRotate2.transform.rotation = Quaternion.Lerp(startRotation2, targetRotation2, lerpDuration * speed);
                lerpDuration = lerpDuration + Time.deltaTime;
                print(doorRotate1.transform.rotation.y);
                if (swingTime >= 4.3f)
                {
                    gm.openDoor = false;
                    gm.kitchenDoor = true;
                    //print("TIMERS DONE");
                }
                /*
                if (doorRotate1.transform.rotation.y <= -.97 && doorRotate2.transform.rotation.y >= .97)
                {
                    rotating = false;
                    gm.openDoor = false;
                    gm.kitchenDoor = true;
                    //TODO: Vedika put in the timer for the room change here
                }*/
            
               
            }
        }

        

        doorRigid1.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ| RigidbodyConstraints.FreezeRotation;
        doorRigid2.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
        if (codeText != null)
        {
            codeText.text = codeTextValue;
        }

        //codeTextValueInt = int.Parse(codeTextValue.Trim());
        //doorCodeInt = int.Parse(doorCode.Trim());

        //print(int.Parse(clockScript.theCode)+int.Parse(codeTextValue));
        //print(codeTextValue);

        if (codeTextValue.Length == 4)
        {
            //one way to open the door is to check the clock
            //first check to see if a clock is in the room
            if (clockScript != null)
            {
                if (((int.Parse(clockScript.theCode) + tolerance) >= int.Parse(codeTextValue) &&
                     (int.Parse(clockScript.theCode) - tolerance) <= int.Parse(codeTextValue)))
                {

                    //codeTextValue >= clockScript.theCode.int.Parse -8 && codeTextValue <= clockScript.theCode ++ 8
                    //DO THIS NEXT CLASS CONVERT TO INTEGER
                    //also figure out the issue with templayer chasing bool
                    //its working !!!!
                    gm.openDoor = true;
                }
            }
            //there is no clock in this room
            else
            {
                gm.openDoor = true;
            }

        }

        if(codeTextValue.Length >= 5)
        {
            codeTextValue = "";
        }

        //if (openDoor)
        //{
        //    doorRigid1.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
            
        //    rotating = true;
        //    //if (rotating)
        //    //{
        //    //    Quaternion startRotation = doorRotate1.transform.rotation;
        //    //    Quaternion targetRotation = doorRotate1.transform.rotation * Quaternion.Euler(0, -90, 0);
        //    //    doorRotate1.transform.rotation = Quaternion.Lerp(startRotation, targetRotation, lerpDuration * speed);
        //    //    lerpDuration = lerpDuration + Time.deltaTime;
        //    //    print(doorRotate1.transform.rotation.y);
        //    //    if (doorRotate1.transform.rotation.y <= -.97)// || doorRotate1.transform.rotation == targetRotation)
        //    //    {
        //    //        rotating = false;
        //    //    }
        //    //}
        //}

        
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

        print(codeTextValue);
        
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (button1.coll)
    //    {
    //        codeText.text = codeTextValue;
    //    }
    //}
}
// next class you need to get the buttons working in VR, they should be already but they are not
