using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngredientsCorrect : MonoBehaviour
{
    GameManager gm;
    TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = gm.doughPlacement.ToString();
    }
}
