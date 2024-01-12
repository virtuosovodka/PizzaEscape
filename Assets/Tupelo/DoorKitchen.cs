using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DoorKitchen : MonoBehaviour
{
    public GameObject door;
    public bool openDoor;
    private bool isAtDoor = false;
   
  

    [SerializeField]private TextMeshProUGUI codeText;
    string codeTextValue = "";
    public string doorCode;
    public GameObject codePanel;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == doorCode)
        {
            openDoor = true;
        }

        if(codeTextValue.Length >= 4)
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
