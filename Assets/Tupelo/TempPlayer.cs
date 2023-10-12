using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempPlayer : MonoBehaviour
{
    //Start is called before the first frame update
    // void Start()
    //{
    //    public GameObject torch;
    //}
    public bool chasePlayer;
    private float timeRemaining = 10;
    [SerializeField] private float pizzaSpeed = 5;
    [SerializeField] public Rigidbody knotBody;

    // Update is called once per frame
    void Update()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // vector 3 is shrthand for (0,0,1)

        knotBody.velocity = pizzaSpeed * dir;
        //rigid body is in inspector, Y is frozen until we add a floor

        if (timeRemaining > 0)

        {

            timeRemaining -= Time.deltaTime;

        }
        else if (timeRemaining <= 0 && timeRemaining >= -1)
        {
            //print("time is up");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pizzaMan"))
        {
            print("You are dead.");

        }
        else if (other.CompareTag("floorTrigger"))
        {
            chasePlayer = true;
        }
        else if (other.CompareTag("floorNormal"))
        {
            chasePlayer = false;
        }
    }
}
