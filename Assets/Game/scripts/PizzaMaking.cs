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
    public int mushroomNumber = 0;
    public int pineappleNumber = 0;
    public int hamNumber = 0;
    public Vector3 endPosition;
    public Vector3 startPosition;
    //float printerSpeed = .02f;
    private float startTime;
    private float journeyLength;

    public bool pizzasDone;
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
    public float smoothTime = .5f;
    public float speed;
    Vector3 velocity;

    //lerp

    // Start is called before the first frame update
    void Start()
    {
        orderOne.SetActive(false);
        orderTwo.SetActive(false);
        orderThree.SetActive(false);

        randomNumber = Random.Range(1, 3);

        
        //endPosition = new Vector3(18.62f, 2.66f, 3.97f);
        //menuPiece2.transform.position = startPosition;
        startTime = Time.time;
        //journeyLength = Vector3.Distance(startPosition, endPosition);
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
                cheese3.SetActive(false);
            }
        }
        if (order2)
        {
            orderTwo.SetActive(true);
            //print("order 2 is up");
            if (pepperoniNumber == 6)
            {
                pizza1Done = true;
                cheese1.SetActive(false);
            }
            if (mushroomNumber == 4)
            {
                pizza2Done = true;
                cheese2.SetActive(false);
            }
            if (pineappleNumber == 0 && hamNumber == 5)
            {
                pizza3Done = true;
                cheese3.SetActive(false);
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
            if (pineappleNumber == 3 && hamNumber == 5)
            {
                pizza3Done = true;
                cheese3.SetActive(false);
            }
        }

        if (pizza1Done  ||  pizza3Done || pizza2Done )
        {
            pizzasDone = true;
            //float distCovered = (Time.time - startTime) * printerSpeed;
            //float fractionOfJourney = distCovered / journeyLength;
            //menuPiece2.transform.position = Vector3.Lerp(startPosition, endPosition, fractionOfJourney);

            //menuPiece2.transform.position = Vector3.SmoothDamp(transform.position, endPosition, ref velocity, smoothTime, speed);
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
        //if (collision.gameObject.CompareTag("mushroom"))
        //{
        //    if (!toppingsAdded.Contains(collision.gameObject.name))
        //    {
        //        timerOne = 0f;
        //        //var mushroom = collision.gameObject;
        //        //mushroom.transform.parent = cheese2.transform;
        //        //print("mushroom parented");
        //        mushroomNumber = mushroomNumber + 1;
        //        toppingsAdded.Add(collision.gameObject.name);
        //    }
        //}
        //if (collision.gameObject.CompareTag("pineapple"))
        //{
        //    if (!toppingsAdded.Contains(collision.gameObject.name))
        //    {
        //        timerOne = 0f;
        //        pineappleNumber = pineappleNumber + 1;
        //        toppingsAdded.Add(collision.gameObject.name);
        //    }
        //}
        //if (collision.gameObject.CompareTag("ham"))
        //{
        //    if (!toppingsAdded.Contains(collision.gameObject.name))
        //    {
        //        timerOne = 0f;
        //        hamNumber = hamNumber + 1;
        //        toppingsAdded.Add(collision.gameObject.name);
        //    }
        //}

    }

}