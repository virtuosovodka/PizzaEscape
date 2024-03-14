using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PianoKeySounds : MonoBehaviour
{
    public string[] password = new string[3] { "G", "C", "E" };
    public List<string> ipk = new List<string>();
    public string[] keyList = new string[3];
    public TextMeshProUGUI text;
    //bool enterLoop = true;
    //IPk, stands for Input Keys.
    public GameObject piano;
    public AudioSource C;
    public AudioSource D;
    public AudioSource E;
    public AudioSource F;
    public AudioSource G;
    public AudioSource A;
    public AudioSource B;
    public GameManager gm;
    
    // Start is called before the first frame update
    public void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        print(ipk.Count);
        print(ipk);
        text.text = "" + ipk.Count;
        if (ipk.Count >= 3)
        {
            keyList = ipk.GetRange(ipk.Count - 3, 3).ToArray();
            Compare(password, keyList);
        }
    }
    private void C_play()
    {
        C.Play();
        ipk.Add("C");
        text.text = "C Pressed!";
    }
    private void D_play()
    {
        D.Play();
        ipk.Add("D");
        text.text = "D Pressed!";
    }
    private void E_play()
    {
        E.Play();
        ipk.Add("E");
        text.text = "E Pressed!";
    }
    private void F_play()
    {
        F.Play();
        ipk.Add("F");
        text.text = "F Pressed!";
    }
    private void G_play()
    {
        G.Play();
        ipk.Add("G");
        text.text = "G Pressed!";
    }
    private void A_play()
    {
        A.Play();
        ipk.Add("A");
        text.text = "A Pressed!";

    }
    private void B_play()
    {
        B.Play();
        ipk.Add("B");
        text.text = "B Pressed!";
    }
    
    private void OnCollisionEnter(Collision collision)
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

    void Compare (string[] password, string[] keylist)
    {
        if (password[0] == keylist[0] && password[1] == keylist[1] && password[2] == keylist[2])
        {
            gm.keyboardPlayed = true;
        }
        else
        {
            gm.keyboardPlayed = false;
        }
    }
    
}
   


