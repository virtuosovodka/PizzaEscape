using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKitchen : MonoBehaviour
{
    public GameObject door;
    public bool openDoor;

    // Start is called before the first frame update
    void Start()
    {
        openDoor = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (openDoor)
        {
            transform.Translate(Vector3.left * 1f * Time.deltaTime);
        }

        if (door.transform.position.z >= 5)
        {
            openDoor = false;
        }
    }
}
