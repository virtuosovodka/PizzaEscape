using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRotation : MonoBehaviour
{
    [SerializeField]
    Transform trans;

    Quaternion rot;

    private void Start()
    {
        if(trans == null)
        {
            trans = transform;
        }
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        rot = trans.rotation;
    }

    public void Reset()
    {
        trans.rotation = rot;
    }
}
