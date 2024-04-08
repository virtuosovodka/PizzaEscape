using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using TMPro;

public class PianoKeySounds : MonoBehaviour
{
    public List<string> password = new List<string>(){ "G", "E", "C" };
    public List<string> ipk = new List<string>();
    
    [SerializeField]
    private TextMeshProUGUI text;
    //IPK, stands for Input Keys.
    public AudioSource C;
    public AudioSource D;
    public AudioSource E;
    public AudioSource F;
    public AudioSource G;
    public AudioSource A;
    public AudioSource B;
    public GameManager gm;

    public void Start()
    {
        text.text = "hello this is for sure unique";
    }

    public void Update()
    {
        //text.text = ipk.ToString();
        Compare(password, ipk);
    }

    private void C_play()
    {
        C.Play();
        ipk.Insert(0, "C");
        //text.text = "C Pressed!";
        Compare(password, ipk);
    }
    private void D_play()
    {
        D.Play();
        ipk.Insert(0, "D");
        //text.text = "D Pressed!";
        Compare(password, ipk);
    }
    private void E_play()
    {
        E.Play();
        ipk.Insert(0, "E");
        //text.text = "E Pressed!";
        Compare(password, ipk);
    }
    private void F_play()
    {
        F.Play();
        ipk.Insert(0, "F");
        //text.text = "F Pressed!";
        Compare(password, ipk);
    }
    private void G_play()
    {
        G.Play();
        ipk.Insert(0, "G");
        //text.text = "G Pressed!";
        Compare(password, ipk);
    }
    private void A_play()
    {
        A.Play();
        ipk.Insert(0, "A");
        //text.text = "A Pressed!";
        Compare(password, ipk);

    }
    private void B_play()
    {
        B.Play();
        ipk.Insert(0, "B");
        //text.text = "B Pressed!";
        Compare(password, ipk);
    }
    
    private void OnTriggerEnter(Collider collision)
    {
            if (collision.gameObject.CompareTag("C"))
            {
                C_play();
            }
            else if (collision.gameObject.CompareTag("D"))
            {
                D_play();
            }
            else if (collision.gameObject.CompareTag("E"))
            {
                E_play();
            }
            else if (collision.gameObject.CompareTag("F"))
            {
                F_play();
            }
            else if (collision.gameObject.CompareTag("G"))
            {
                G_play();
            }
            else if (collision.gameObject.CompareTag("A"))
            {
                A_play();
            }
            else if (collision.gameObject.CompareTag("B"))
            {
                B_play();
            }
    }

    bool Compare(List<string> password, List<string> keyList)
    {
        //text.text = "Number of keys in string: " + keyList.Count + " Keys in string: " + keyList[0] + keyList[1] + keyList[2];
        if (keyList.Count < password.Count)
        {
            gm.keyboardPlayed = false;
            text.text = "false";
            return false;
        }

        if (password[2] == keyList[2] && password[1] == keyList[1] && password[0] == keyList[0])
        {
            gm.keyboardPlayed = true;
            text.text = "true";
            return true;
        }
        
        gm.keyboardPlayed = false;
        text.text = "false";
        return false;
            
    }

}
   


