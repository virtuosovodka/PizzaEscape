using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PizzaMan : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    private NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //navMeshAgent.transform.position = new Vector3(2, 0, 0);


        //set up raycasting, if raycast finds something within a few feet then{

        navMeshAgent.destination = movePositionTransform.position;
        //}


    }
}
