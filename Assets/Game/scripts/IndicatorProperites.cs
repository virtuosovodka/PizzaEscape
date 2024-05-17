using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorProperites : MonoBehaviour
{
    public bool green;
    public int shelf;

    private MeshRenderer mesh;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        if(green)
        {
            mesh.enabled = false;
        }
    }

    public void Show()
    {
        mesh.enabled = true;
    }

    public void Hide()
    {
        mesh.enabled = false;
    }
}
