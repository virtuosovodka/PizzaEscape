using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoughPuzzle : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject placemat;

    public TextMeshProUGUI textMesh;

    public float timer = 0.0f;
    private bool onSurface;

    private Rigidbody rigidBody;

    public LoadNewScene loadNewScene;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        loadNewScene = FindObjectOfType<LoadNewScene>();

        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateText(gameManager);

        if (onSurface && rigidBody.constraints != RigidbodyConstraints.FreezeAll)
        {
            timer += Time.deltaTime;
            if (timer > 0.3f)
            {
                rigidBody.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        timer = 0.0f;
        onSurface = true;

        // If the object the dough bag collided with is the placemat...
        if (other.gameObject == placemat)
        {
            gameManager.doughPlacement++;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        rigidBody.constraints = RigidbodyConstraints.None;
        onSurface = false;

        // If the dough bag is removed from placemat...
        if (other.gameObject == placemat)
        {
            gameManager.doughPlacement--;
        }
    }

    private void UpdateText(GameManager gameManager)
    {
        if (!gameManager || !textMesh) { return; }

        string newText = gameManager.doughPlacement.ToString()
            + ' '
            + gameManager.timer.ToString();

        textMesh.text = newText;
    }
}


