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
    public GameObject button1;

    [SerializeField]private TextMeshProUGUI codeText;
    public string codeTextValue = "";
    int codeTextValueInt;
    public string doorCode;
    public GameObject codePanel;
    int doorCodeInt;
    int tolerance = 8;
    public bool addingDig;
    Rigidbody doorRigid;
    public bool freezePos = true;
    public bool freezeOthers = true;
    public GameObject doorRotate1;
    public GameObject doorRotate2;
    float lerpDuration = .5f;
    bool rotating;

    // Start is called before the first frame update
    void Start()
    {
        clockScript = GameObject.FindObjectOfType<ClockScript>();
        //addingDig = false;
        doorRigid = door.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        doorRigid.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ| RigidbodyConstraints.FreezeRotation;
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
            doorRigid.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
            //rotating = true;
            float timeElapsed = 0;
            Quaternion startRotation = doorRotate1.transform.rotation;
            Quaternion targetRotation = doorRotate1.transform.rotation * Quaternion.Euler(0, 0, -90);
            while (timeElapsed < lerpDuration)
            {
                //doorRotate1.transform.rotation = Quaternion.Slerp(startRotation, targetRotation);
            }
            doorRotate1.transform.Rotate(0f, 0f, -90f);

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
        print("itar is working");
        
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
