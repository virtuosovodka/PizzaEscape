using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Slot : MonoBehaviour
{
    public GameObject ItemInSlot;
    public Image slotImage;
    private Color originalColor;
    public TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        text.text = "On and ready to work!";
        slotImage = GetComponentInChildren<Image>();
        originalColor = slotImage.color;
    }

    private void OnTriggerStay(Collider other)
    {
        text.text = "" + other.name + name;
        if (ItemInSlot != null) return;
        GameObject obj = other.gameObject;
        if (!ItemCheck(obj)) return;
        InsertItem(obj);
    }
    

    bool ItemCheck(GameObject obj)
    {
        return obj.GetComponent<Item>();
    }

    void InsertItem(GameObject obj)
    {
        obj.transform.SetParent(this.transform, false);
        obj.GetComponent<Rigidbody>().isKinematic = true;
        obj.transform.localPosition = new Vector3(0,0,0);
        obj.transform.localEulerAngles = obj.GetComponent<Item>().slotRotation;
        obj.GetComponent<Item>().inSlot = true;
        obj.GetComponent<Item>().currentSlot = this;
        ItemInSlot = obj;
        slotImage.color = Color.gray;
    }

    public void ResetColor()
    {
        slotImage.color = originalColor;
    }
}
