using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PianoKeySounds : MonoBehaviour

{
    public string[] password = new string[3] { "G", "C", "E" };
    public List<string> IPK = new List<string>();
    public string[] keylist = new string[3];
    public TextMeshProUGUI text;
    bool enterLoop = true;
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
        
        if (enterLoop)
        {
            if (IPK.Count >= 3)
            {
                Compare(password, keylist);
                keylist = IPK.GetRange(IPK.Count - 3, 3).ToArray();
                //(GetRange(index,Count)
                /*keylist = new string[IPK.Count];


                 for (int i = 0; i < IPK.Count; i++)
                 {
                     keylist[i] = IPK[IPK.Count - 3+i];

                     if (i == IPK.Count - 1)
                     {

                         bool success = compare(password, keylist);
                         print(success);
                         Debug.Log(keylist[0] + "" + keylist[1] + "" + keylist[2] );

                         enterLoop = false;

                     }
                 }

                 IPK[0] = IPK[1];
                 IPK[1] = IPK[2];
                 IPK.RemoveAt(2);

               if (compare)
                 {
                     Debug.Log("Success");
                 }
             }*/



            }

        }
    }
    public void C_play()
    {
        C.Play();
        IPK.Add("C");
        print("C");
        text.text = "C Pressed!";
    }
    public void D_play()
    {
        D.Play();
        IPK.Add("D");
        print("D");
        text.text = "D Pressed!";
    }
    public void E_play()
    {
        E.Play();
        IPK.Add("E");
        print("E");
        text.text = "E Pressed!";
    }
    public void F_play()
    {
        F.Play();
        IPK.Add("F");
        print("F");
        text.text = "F Pressed!";
    }
    public void G_play()
    {
        G.Play();
        IPK.Add("G");
        print("G");
        text.text = "G Pressed!";
    }
    public void A_play()
    {
        A.Play();
        IPK.Add("A");
        print("A");
        text.text = "A Pressed!";

    }
    public void B_play()
    {
        B.Play();
        IPK.Add("B");
        print("B");
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
        else
        {
            text.text = ":)";
        }
    }

   /*string[] Convert(List<string> list)
    {
        
        if (list.Count == password.Length)
        {
            //list.FindLast();
            keylist = list.ToArray();
        }
        else
        {
            keylist = null;
        }
        return keylist;
    }*/
   
    

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
   


