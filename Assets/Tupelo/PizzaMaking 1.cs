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
   
   
    public bool order1;
    public bool order2;
    public bool order3;
    public GameObject orderOne;
    public GameObject orderTwo;
    public GameObject orderThree;

    public GameObject cheese1;
    public GameObject cheese2;
    public GameObject cheese3;
    float randomNumber;
    public float delay = 4f;
    public float timerOne = 0f;

    public List<string> toppingsAdded;
    //public List<string> mushroomsAdded;
    //public List<string> pineappleAdded;
    //public List<string> pineappleAdded;

    //lerp



    // Start is called before the first frame update
    void Start()
    {
        orderOne.SetActive(false);
        orderTwo.SetActive(false);
        orderThree.SetActive(false);

        randomNumber = Random.Range(1, 3);
        
        menuPiece2.transform.position = startPosition;
        endPosition = new Vector3(18.62f, 2.66f, 3.97f);
        startPosition = new Vector3(18.62f, 2.42f, 3.63f);
        startTime = Time.time;
        journeyLength = Vector3.Distance(startPosition, endPosition);
       // int rand = Random.Range(1, 4);
       
    }
 
    // Update is called once per frame
    void Update()
    {
        //System.Random random = new System.Random();
        //print(randomNumber);
        timerOne += Time.deltaTime;
        if (randomNumber == 1)
        {
           // print("okay it is working till here");
            order1 = true;
            order2 = false;
            order3 = false;
        }
        if (randomNumber == 2)
        {
           // print("okay it is working till here");
            order1 = false;
            order2 = true;
            order3 = false;
        }
        if (randomNumber == 3)
        {
           // print("okay it is working till here");
            order1 = false;
            order2 = false;
            order3 = true;
        }
        if (order1)
        {
            // print("order 1 is up");
            orderOne.SetActive(true);
            if (pepperoniNumber == 4)
            {
                pizza1Done = true;
                cheese1.SetActive(false);
            }
            if (mushroomNumber == 8)
            {
                pizza2Done = true;
                cheese2.SetActive(false);

            }
            if (pineappleNumber == 4 && hamNumber == 3)
            {
                pizza3Done = true;
            }
        }
        if (order2)
        {
            orderTwo.SetActive(true);
            //print("order 2 is up");
            if (pepperoniNumber == 4)
            {
                pizza1Done = true;
                cheese1.SetActive(false);
            }
            if (mushroomNumber == 5)
            {
                pizza2Done = true;
                cheese2.SetActive(false);
            }
            if (pineappleNumber == 6 && hamNumber == 0)
            {
                pizza3Done = true;
            }
        }
        if (order3)
        {
            orderThree.SetActive(true);
            //print("order 3 is up");
            if (pepperoniNumber == 4)
            {
                pizza1Done = true;
                cheese1.SetActive(false);
            }
            if (mushroomNumber == 6)
            {
                pizza2Done = true;
                cheese2.SetActive(false);
            }
            if (pineappleNumber == 0 && hamNumber == 8)
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
        //if (timerOne > delay)
        //    print("past delay");

        if (collision.gameObject.CompareTag("pepperoni"))
        {
            if (!toppingsAdded.Contains(collision.gameObject.name))
            {

                timerOne = 0f;
                print(pepperoniNumber);
                //transform.parent = cheese1.transform;
                //pepperoniNumber = pepperoniNumber + 1;
                //handScript.transform.SetParent(null);
                pepperoniNumber = pepperoniNumber + 1;
                toppingsAdded.Add(collision.gameObject.name);
            }
        }
            if (collision.gameObject.CompareTag("mushroom"))
            {
            if (!toppingsAdded.Contains(collision.gameObject.name))
            {
                timerOne = 0f;
                //var mushroom = collision.gameObject;
                //mushroom.transform.parent = cheese2.transform;
                //print("mushroom parented");
                mushroomNumber = mushroomNumber + 1;
            }
            }
            if (collision.gameObject.CompareTag("pineapple"))
            {
            if (!toppingsAdded.Contains(collision.gameObject.name))
            {
                timerOne = 0f;
                pineappleNumber = pineappleNumber + 1;
            }
            }
            if (collision.gameObject.CompareTag("ham"))
            {
            if (!toppingsAdded.Contains(collision.gameObject.name))
            {
                timerOne = 0f;
                hamNumber = hamNumber + 1;
            }
            }
        
    }
    
}
