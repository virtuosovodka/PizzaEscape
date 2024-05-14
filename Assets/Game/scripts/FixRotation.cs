using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class FixRotation : MonoBehaviour
{
    private Vector3 rotation;
    
    // Start is called before the first frame update
    void Start()
    {
        rotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        rotation.x = transform.rotation.eulerAngles.x;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
