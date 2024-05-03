using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LockerCombo : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI first;
    [SerializeField]
    TextMeshProUGUI second;
    [SerializeField]
    TextMeshProUGUI third;

    private float numOne; // right fly up at 0 degrees
    private float numTwo; // right fly up, left fly down
    private float numThree; // left fly down
    private float error = 2f / 40f;
    private float flySize = 1f / 40f;
    
    private float prevPos;
    private float newPos;

    private Vector3 combo;
    
    
    // Start is called before the first frame update
    void Start()
    {
        numOne = 0f;
        numTwo = 0.5f;
        numThree = 0f;

        // First number, second number, third number
        combo = new Vector3(1f, 15f, 24f);

        prevPos = position();
    }

    // Update is called once per frame
    void Update()
    {
        newPos = position();

        int display = (int)Mathf.Round(newPos * 40f);
        if(display == 40)
        {
            display = 0;
        }
        second.text = display.ToString();

        rotate(newPos - prevPos);
        prevPos = newPos;

        if (checkCombo())
        {
            first.text = "Solved!";
            second.text = "Solved!";
            third.text = "Solved!";
        }

        /*
        first.text = (Mathf.Round(numOne * 40f)).ToString();
        second.text = (Mathf.Round(numTwo * 40f)).ToString();
        third.text = (Mathf.Round(numThree * 40f)).ToString();
        */
    }

    // Rotation of next wheel once they have locked together
    float calcRotationTogether(float pos1, float pos2, float rotation)
    {
        float rot1 = 0f;
        float diff = (pos2 - pos1); // should have opposite sign of rotation

        if (rotation > 0f)
        {

            if (diff > 0f)
            {
                diff -= 1f;
            }

            // diff2 + fraction is distance past dial2 that dial3 would turn
            if (diff + rotation + flySize > 0f)
            {
                rot1 = diff + rotation + flySize;
            }
        }
        else if(rotation < 0f)
        {
            if (diff < 0f)
            {
                diff += 1;
            }
            
            if ((diff + rotation) - flySize < 0f)
            {
                rot1 = (diff + rotation) - flySize;
            }
        }

        return rot1;
    }

    void rotate(float fraction)
    {
        if (fraction > 0.5f)
        {
            fraction -= 1f;
        }
        else if (fraction < -0.5f)
        {
            fraction += 1f;
        }

        float rotation3 = fraction;
        float rotation2 = calcRotationTogether(numTwo, numThree, rotation3);
        float rotation1 = calcRotationTogether(numOne, numTwo, rotation2);

        numOne += rotation1;
        numTwo += rotation2;
        numThree += rotation3;

        if (numOne < 0f)
        {
            numOne += 1f;
        }
        if (numTwo < 0f)
        {
            numTwo += 1f;
        }
        if (numThree < 0f)
        {
            numThree += 1f;
        }
        if (numOne >= 1f)
        {
            numOne -= 1f;
        }
        if (numTwo >= 1f)
        {
            numTwo -= 1f;
        }
        if (numThree >= 1f)
        {
            numThree -= 1f;
        }
    }

    float position()
    {
        return (transform.localRotation.eulerAngles.y / 360f);
    }

    bool checkCombo()
    {
        if (Mathf.Abs((numOne - 2f * flySize) - combo.x / 40f) <= error && Mathf.Abs((numTwo - flySize) - combo.y / 40f) <= error && Mathf.Abs(numThree - combo.z / 40f) <= error)
        {
            return true;
        }

        return false;
    }
}
