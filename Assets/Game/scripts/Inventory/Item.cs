using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool inSlot = false;
    public Vector3 slotRotation = Vector3.zero;
    public Slot currentSlot;
    private Transform grabbableObjects;

    void Start()
    {
        grabbableObjects = transform.parent;
    }

    public void OnRelease()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb.useGravity == false)
        {
            transform.SetParent(grabbableObjects);
            rb.isKinematic = false;
            rb.useGravity = true;
            // obj.transform.localPosition = new Vector3(0,0,0);
            inSlot = false;
            currentSlot = null;
        }
    }
}
