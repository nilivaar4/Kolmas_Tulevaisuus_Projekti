using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//using System.Diagnostics;

public class randomEvent : MonoBehaviour
{
    public Text rngText;
    public bool yesno;
    public int choice;
    public GameObject week, stress;
    System.Random rnd = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        //rngText.text = "";
        //yesno = true;
        choice = rnd.Next(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        //   rngEvent();
       // rngChoice();
    }

    public void makeChoice()
    {
        yesno = true;
        Debug.Log("yesno");

    }

    public void rngEvent()
    {
        //yesno = false;
        choice = rnd.Next(1, 6);
        Debug.Log("22222");


        if (choice == 1)
        {
            rngText.text = "Kamerusten kanssa pämppää";
            
        }
     
        if (choice == 2)
        {
            rngText.text = "Roadtripille halki suomen";
        }
        if (choice == 3)
        {
            rngText.text = "Bilettää";
           
        }
        if (choice == 4)
        {
            rngText.text = "Tinder reffeille";
            
        }
        if (choice == 5)
        {
            rngText.text = "Kalsarigännit";           
        }
    }
    public void rngChoice()
    {
        if (choice == 1 && yesno == true)
        {
            stress.GetComponent<stressAmount>().subtractHealth(10);
            Debug.Log("1");
            
        }
        if (choice == 2 && yesno == true)
        {
            stress.GetComponent<stressAmount>().subtractHealth(20);
            Debug.Log("2");      
        }
        if(choice == 3 && yesno == true)
        {
            stress.GetComponent<stressAmount>().subtractHealth(30);
            Debug.Log("3");

        }
        if (choice == 4 && yesno == true)
        {
            stress.GetComponent<stressAmount>().subtractHealth(40);
            Debug.Log("4");
        }
        if(choice == 5 && yesno == true)
        {
            stress.GetComponent<stressAmount>().subtractHealth(50);
            Debug.Log("5");

        }

    }
}
