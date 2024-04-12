using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class PianoKeySounds : MonoBehaviour
{
    private List<string> _password = new();
    private List<string> _ipk = new();
    public LoadNewScene lns;
    
    [SerializeField]

    public GameManager gm;

    public void Start()
    {
        _password = new List<string>(){ "G", "E", "C" };
        gm = FindObjectOfType<GameManager>();
        lns = FindObjectOfType<LoadNewScene>();
        lns.pizzaMonster.SetActive(false);
        lns.pizzaMonsterText.text = "CEG";
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent(out PianoKey key))
        {
            _ipk.Insert(0, key.Play());
            
            gm.keyboardPlayed = Compare(_password, _ipk);
        }
    }

    bool Compare(List<string> password, List<string> keyList)
    {
        if (keyList.Count < password.Count)
        {
            return false;
        }
        
        if (keyList.Count > password.Count)
        {
            keyList.RemoveRange(password.Count, keyList.Count - password.Count);
        }
        
        if (!keyList.SequenceEqual(password))
        {
            return false;
        }
        
        return true;
    }

}
   


