using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PianoKeySounds : MonoBehaviour
{
    public List<string> password = new List<string>(){ "G", "C", "E" };
    public List<string> ipk = new List<string>();
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
        if (password[0] == ipk[0] && password[1] == ipk[1] && password[2] == ipk[2])
        {
            //gm.keyboardPlayed = true;
            print(true);
        }
        else
        {
            //gm.keyboardPlayed = false;
            print(false);
        }
    }

    private void Update()
    {
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

    void Compare (List<string> password, List<string> keyList)
    {
        if (keyList.Count < 3)
        {
            return;
        }

        if (password[0] == keyList[0] && password[1] == keyList[1] && password[2] == keyList[2])
        {
            gm.keyboardPlayed = true;
            print(true);
        }
        else
        {
            gm.keyboardPlayed = false;
            print(false);
        }
    }
    
}
   


