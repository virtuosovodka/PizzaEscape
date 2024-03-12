using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scrip : MonoBehaviour
{
    
    public GameObject locker;
    private LockerCombo rotation;
    public TextMeshProUGUI text; 
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        rotation = locker.GetComponent<LockerCombo>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Mathf.Round(rotation.numOne * 40f) + "\n" + Mathf.Round(rotation.numTwo * 40f) + "\n" + Mathf.Round(rotation.numThree * 40f);
    }
}
