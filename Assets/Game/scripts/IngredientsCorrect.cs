using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngredientsCorrect : MonoBehaviour
{
    GameManager gm;
    TextMeshProUGUI text;

    GameObject[] indicators;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        text = GetComponent<TextMeshProUGUI>();

        indicators = GameObject.FindGameObjectsWithTag("indicator");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = gm.doughPlacement.ToString();
    }

    public void changeIndicator(int shelf, bool green)
    {
        for(int i = 0; i < indicators.Length; i++)
        {
            IndicatorProperites props = indicators[i].GetComponent<IndicatorProperites>();
            if (props.shelf == shelf)
            {
                if(props.green == green)
                {
                    indicators[i].SetActive(true);
                } else
                {
                    indicators[i].SetActive(false);
                }
            }
        }
    }
}
