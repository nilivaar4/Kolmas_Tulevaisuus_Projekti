using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//using System.Diagnostics;

public class randomEvent : MonoBehaviour
{
    public Text rngText;
    public bool yesno = false;
    public GameObject week;
    System.Random rnd = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        //rngText.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
     //   rngEvent();
    }

    public void makeChoice()
    {
        yesno = true;
    }

    public void rngEvent()
    {
        int choice = rnd.Next(1, 6);
        Debug.Log("22222");

        if (choice == 1)
        {
            rngText.text = "Kamerusten kanssa pämppää";
            Debug.Log("55555554");
            if (yesno == true)
            {
                week.GetComponent<playerMoney>().subtractMoney(30);
                Debug.Log("1");
            }
        }
        if (choice == 2)
        {
            rngText.text = "Roadtripille halki suomen";
            Debug.Log("6554645645654");

            if (yesno == true)
            {
                week.GetComponent<playerMoney>().subtractMoney(30);
                Debug.Log("2");

            }
        }
        if (choice == 3)
        {
            rngText.text = "Bilettää";
            if (yesno == true)
            {
                week.GetComponent<playerMoney>().subtractMoney(30);
                Debug.Log("3");

            }
        }
        if (choice == 4)
        {
            rngText.text = "Tinder reffeille";
            if (yesno == true)
            {
                week.GetComponent<playerMoney>().subtractMoney(30);
                Debug.Log("4");

            }
        }
        if (choice == 5)
        {
            rngText.text = "Kalsarigännit";
            if (yesno == true)
            {
                week.GetComponent<playerMoney>().subtractMoney(30);
                Debug.Log("5");

            }
        }
    }
}
