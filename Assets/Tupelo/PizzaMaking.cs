using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaMaking : MonoBehaviour
{
    public bool pizza1Done;
    public bool pizza2Done;
    public bool pizza3Done;
    public GameObject menuPiece2;
    int pepperoniNumber = 0;
    int mushroomNumber = 0;
    int pineappleNumber = 0;
    int hamNumber = 0;
    Vector3 endPosition;
    Vector3 startPosition;
    float printerSpeed = .02f;
    private float startTime;
    private float journeyLength;
    public GameObject hand;
    public Hand handScript;
    public bool order1;
    public bool order2;


    //lerp
  


    // Start is called before the first frame update
    void Start()
    {
        handScript = FindObjectOfType<Hand>();
        menuPiece2.transform.position = startPosition;
        endPosition = new Vector3(18.62f, 2.66f, 3.97f);
        startPosition = new Vector3(18.62f, 2.42f, 3.63f);
        startTime = Time.time;
        journeyLength = Vector3.Distance(startPosition, endPosition);
        Main();
    }
    static void Main()
    {

        System.Random random = new System.Random();
        int rand = random.Next(1, 3);

        //work on referencing this number that is in the static void, in the update segment
    }
    // Update is called once per frame
    void Update()
    {
        System.Random random = new System.Random();
        int rand = random.Next(1, 3);
        print(rand);
        //if (rand == 1)
        //{
        //    order1 = true;
        //}
        if (order1)
        {

            if (pepperoniNumber == 5)
            {
                pizza1Done = true;
            }
            if (mushroomNumber == 6)
            {
                pizza2Done = true;
            }
            if (pineappleNumber == 5 && hamNumber == 4)
            {
                pizza3Done = true;
            }
        }
        if (order2)
        {

            if (pepperoniNumber == 10)
            {
                pizza1Done = true;
            }
            if (mushroomNumber == 5)
            {
                pizza2Done = true;
            }
            if (pineappleNumber == 6 && hamNumber == 0)
            {
                pizza3Done = true;
            }
        }


        if (pizza1Done && pizza2Done && pizza3Done)
        {
            float distCovered = (Time.time - startTime) * printerSpeed;
            float fractionOfJourney = distCovered / journeyLength;
            menuPiece2.transform.position = Vector3.Lerp(startPosition, endPosition, fractionOfJourney);
            //menuPiece2.transform.position = Vector3.MoveTowards(startPosition, endPosition, printerSpeed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("pepperoni"))
        {
            pepperoniNumber = pepperoniNumber + 1;
            handScript.transform.SetParent(null);
        }
        if (collision.gameObject.CompareTag("mushroom"))
        {
            mushroomNumber = mushroomNumber + 1;
        }
        if (collision.gameObject.CompareTag("pineapple"))
        {
            pineappleNumber = pineappleNumber + 1;
        }
        if (collision.gameObject.CompareTag("ham"))
        {
            hamNumber = hamNumber + 1;
        }
    }
    
}
