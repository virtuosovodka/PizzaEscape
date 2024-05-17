using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetLabel : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI label = GetComponentInChildren<TextMeshProUGUI>();
        label.text = transform.parent.name;
    }
}
