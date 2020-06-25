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
    public GameObject week, stress, food, timepoints;
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
        // rngEvent();
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
        //choice = rnd.Next(1, 6);
       

        //Change the text based on the "int choice"
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

    //When 'yes' Is pressed on the phone, something happens based on the "int choice"
    public void rngChoice()
    {
        if (choice == 1 && yesno == true)
        {
            stress.GetComponent<stressAmount>().addHealth(10);
            food.GetComponent<playerMoney>().subtractMoney(75);
            timepoints.GetComponent<timePoints>().subtracthours(16);

            Debug.Log("1");
            
        }
        if (choice == 2 && yesno == true)
        {
            stress.GetComponent<stressAmount>().addHealth(3);
            food.GetComponent<playerMoney>().subtractMoney(150);
            timepoints.GetComponent<timePoints>().subtracthours(96);

            Debug.Log("2");      
        }
        if(choice == 3 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(45);
            stress.GetComponent<stressAmount>().addHealth(3);
            timepoints.GetComponent<timePoints>().subtracthours(12);

            Debug.Log("3");

        }
        if (choice == 4 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(85);
            stress.GetComponent<stressAmount>().addHealth(4);
            timepoints.GetComponent<timePoints>().subtracthours(4);

            Debug.Log("4");
        }
        if(choice == 5 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(35);
            stress.GetComponent<stressAmount>().addHealth(5);
            timepoints.GetComponent<timePoints>().subtracthours(12);
            Debug.Log("5");

        }

    }
}
