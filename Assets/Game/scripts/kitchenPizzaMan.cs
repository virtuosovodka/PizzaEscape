using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class kitchenPizzaMan : MonoBehaviour
{ 
    [SerializeField] private Transform movePositionTransform;
public NavMeshAgent navMeshAgent;
public float speed = 10;
public GameObject pizzariaMan;
public bool gameWon = false;
    public GameManager gameManager;
    public GameObject fire;
// Start is called before the first frame update
void Start()
{
        //navMeshAgent = GetComponent<NavMeshAgent>();
        pizzariaMan.SetActive(false);
        gameManager = FindObjectOfType<GameManager>();
    }

// Update is called once per frame
void Update()
{
    //navMeshAgent.transform.position = new Vector3(2, 0, 0);


    //set up raycasting, if raycast finds something within a few feet then{

    navMeshAgent.destination = movePositionTransform.position;
    //}


}
private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("pesto"))
    {
        pizzariaMan.SetActive(false);
        gameWon = true;
    }

    if (gameManager.makePestoToKill)
    {
        pizzariaMan.SetActive(true);
            fire.SetActive(false);

    }
}
}