using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Slot : MonoBehaviour
{
    public GameObject itemInSlot;
    public Image slotImage;
    private Color _originalColor;
    public TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        text.text = "On and ready to work!";
        slotImage = GetComponentInChildren<Image>();
        _originalColor = slotImage.color;
    }

    void Update()
    {
        if (this.name == "Slot1")
        {
            text.text = "" + itemInSlot.name;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        text.text = "" + other.name + name;
        if (itemInSlot != null) return;
        GameObject obj = other.gameObject;
        if (!ItemCheck(obj)) return;
        InsertItem(obj);
    }
    
    private void OnTriggerExit(Collider obj)
    {
        obj.transform.parent = null;
        obj.GetComponent<Rigidbody>().isKinematic = false;
        obj.GetComponent<Rigidbody>().useGravity = true;
        obj.transform.localPosition = new Vector3(0,0,0);
        obj.GetComponent<Item>().inSlot = false;
        obj.GetComponent<Item>().currentSlot = null;
        itemInSlot = null;
        ResetColor();
    }

    bool ItemCheck(GameObject obj)
    {
        return obj.GetComponent<Item>();
    }

    void InsertItem(GameObject obj)
    {
        obj.transform.SetParent(this.transform);
        obj.GetComponent<Rigidbody>().isKinematic = true;
        obj.GetComponent<Rigidbody>().useGravity = false;
        obj.transform.localPosition = new Vector3(0,0,0);
        obj.transform.localEulerAngles = obj.GetComponent<Item>().slotRotation;
        obj.GetComponent<Item>().inSlot = true;
        obj.GetComponent<Item>().currentSlot = this;
        itemInSlot = obj;
        slotImage.color = Color.gray;
    }

    public void ResetColor()
    {
        slotImage.color = _originalColor;
    }
}
