using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoKeySounds : MonoBehaviour

{
    public string[] password = new string[3] { "G", "C", "E" };
    public List<string> IPK = new List<string>();
    public string[] keylist = new string[3];
    bool enterLoop = true;
    //IPk, stands for Input Keys.
    public GameObject Pinao;
    public AudioSource C;
    public AudioSource D;
    public AudioSource E;
    public AudioSource F;
    public AudioSource G;
    public AudioSource A;
    public AudioSource B;
    
    // Start is called before the first frame update

    private void Update()
    {
        if (enterLoop)
        {
            if (IPK.Count >= 3)
            {
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
    }
    public void D_play()
    {
        D.Play();
        IPK.Add("D");
    }
    public void E_play()
    {
        E.Play();
        IPK.Add("E");
    }
    public void F_play()
    {
        F.Play();
        IPK.Add("F");
    }
    public void G_play()
    {
        G.Play();
        IPK.Add("G");
    }
    public void A_play()
    {
        A.Play();
        IPK.Add("A");

    }
    public void B_play()
    {
        B.Play();
        IPK.Add("B");
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "C")
        {
            C_play();
        }
        if (collision.gameObject.tag == "D")
        {
            D_play();
        }
        if (collision.gameObject.tag == "E")
        {
            E_play();
        }
        if (collision.gameObject.tag == "F")
        {
            F_play();
        }
        if (collision.gameObject.tag == "G")
        {
            G_play();
        }
        if (collision.gameObject.tag == "A")
        {
            A_play();
        }
        if (collision.gameObject.tag == "B")
        {
            B_play();
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
   
    

    bool compare (string[] password, string[] keylist)
    {
        if (password[0] == keylist[0] && password[1] == keylist[1] && password[2] == keylist[2])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}
   


