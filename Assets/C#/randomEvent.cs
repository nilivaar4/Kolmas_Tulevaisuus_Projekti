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
        choice = rnd.Next(1, 16);
    }

    // Update is called once per frame
    void Update()
    {
         rngEvent();
        // rngChoice();
        
    }

    //Check if "Yes" was pressed ingame
    public void makeChoice()
    {
        yesno = true;
        Debug.Log("yesno");

    }

    public void rngEvent()
    {
        //yesno = false;
        
       

        //Change the text based on the "int choice"
        if (choice == 1)
        {
            rngText.text = "Kaverisi pyysivät mukaan kalaretkelle pariksi päiväksi. Lähdetkö?";           
        }
        if (choice == 2)
        {
            rngText.text = "Kaverisi pyysivät lähtemään roadtripille kiertelemään suomea pariksi päiväksi. Lähdetkö?";
        }
        if (choice == 3)
        {
            rngText.text = "Vanhempasi kyselivät, että josko kävisit heidän luonaan yöpymässä. Lähdetkö?";           
        }
        if (choice == 4)
        {
            rngText.text = "Ystäväsi pyytää sinua mukaansa ravintolaan syömään illallista. Lähdetkö?";  
        }
        if (choice == 5)
        {
            rngText.text = "Kaverisi pyytävät sinut mukaansa juhlimaan baariin. Lähdetkö?";           
        }
        if (choice == 6)
        {
            rngText.text = "Ystävälläsi on syntymäpäivä tänään. Tarjoatko hänelle illallisen?";
        }
        if (choice == 7)
        {
            rngText.text = "Vanhempasi kyselevät, josko sinua kiinnostaisi lähteä käymään heidän luonansa tekemässä vähän kotitöitä rahaa vastaan. Lähdetkö?";
        }
        if (choice == 8)
        {
            rngText.text = "Olet juhlimassa kavereidesi kanssa, ja nämä ilmoittavat, että on sinun vuorosi tarjota kierros juomia. Tarjoatko?";
        }
        if (choice == 9)
        {
            rngText.text = "Äitisi syntymäpäivä on tällä viikolla, ja hän onkin ilmoittanut etukäteen, ettei halua mitään kallista lahjaa. Ostatko hänelle lahjan?";
        }
        if (choice == 10)
        {
            rngText.text = "Videopeli, jonka julkaisua olet odottanut jo pitkään, on viimein julkaistu. Ostatko sen?";
        }
        if (choice == 11)
        {
            rngText.text = "Hammastasi on vihlonut nyt useamman päivän, ja päätät käydä tarkastamassa tilanteen ammattilaisella. Menetkö yksityiselle hammaslääkärille?";
        }
        if (choice == 12)
        {
            rngText.text = "Toisella paikkakunnalla on opiskelijabileet. Lähdetkö?";
        }
        if (choice == 13)
        {
            rngText.text = "Ajattelit, että voisit tänään tehdä vähän parempaa ruokaa kalliimmilla raaka-aineilla. Toimitko näin?";
        }
        if (choice == 14)
        {
            rngText.text = "Paikallisella vaatekaupalla on suuret alennushinnat ja hyviä tuotteita tarjolla. Ostatko sieltä jotain?";
        }
        if (choice == 15)
        {
            rngText.text = "Suosikkiartistisi on soittamassa läheisellä paikkakunnalla. Lähdetkö keikalle?";
        }
    }
    public void choices()
    {
        choice = rnd.Next(1, 16);
    }

    //When 'yes' Is pressed on the phone, something happens based on the "int choice"
    public void rngChoice()
    {
        if (choice == 1 && yesno == true)
        {
            stress.GetComponent<stressAmount>().addHealth(10);
            food.GetComponent<playerMoney>().subtractMoney(50);
            timepoints.GetComponent<timePoints>().subtracthours(48);

            Debug.Log("1");
            
        }
        if (choice == 2 && yesno == true)
        {
            stress.GetComponent<stressAmount>().addHealth(10);
            food.GetComponent<playerMoney>().subtractMoney(100);
            timepoints.GetComponent<timePoints>().subtracthours(96);

            Debug.Log("2");      
        }
        if(choice == 3 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(15);
            stress.GetComponent<stressAmount>().addHealth(5);
            timepoints.GetComponent<timePoints>().subtracthours(24);

            Debug.Log("3");

        }
        if (choice == 4 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(50);
            stress.GetComponent<stressAmount>().addHealth(6);
            timepoints.GetComponent<timePoints>().subtracthours(4);

            Debug.Log("4");
        }
        if(choice == 5 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(45);
            stress.GetComponent<stressAmount>().addHealth(5);
            timepoints.GetComponent<timePoints>().subtracthours(8);
            Debug.Log("5");

        }
        if (choice == 6 && yesno == true)
        {
            stress.GetComponent<stressAmount>().addHealth(10);
            food.GetComponent<playerMoney>().subtractMoney(75);
            timepoints.GetComponent<timePoints>().subtracthours(4);

            Debug.Log("1");

        }
        if (choice == 7 && yesno == true)
        {
            stress.GetComponent<stressAmount>().subtractHealth(10);
            food.GetComponent<playerMoney>().addMoney(75);
            timepoints.GetComponent<timePoints>().subtracthours(6);

            Debug.Log("2");
        }
        if (choice == 8 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(40);
            stress.GetComponent<stressAmount>().addHealth(3);

            Debug.Log("3");

        }
        if (choice == 9 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(20);
            stress.GetComponent<stressAmount>().addHealth(3);

            Debug.Log("4");
        }
        if (choice == 10 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(40);
            stress.GetComponent<stressAmount>().addHealth(5);
            Debug.Log("5");

        }
        if (choice == 11 && yesno == true)
        {
            stress.GetComponent<stressAmount>().addHealth(10);
            food.GetComponent<playerMoney>().subtractMoney(75);
            timepoints.GetComponent<timePoints>().subtracthours(3);

            Debug.Log("1");

        }
        if (choice == 12 && yesno == true)
        {
            stress.GetComponent<stressAmount>().addHealth(5);
            food.GetComponent<playerMoney>().subtractMoney(75);
            timepoints.GetComponent<timePoints>().subtracthours(15);

            Debug.Log("2");
        }
        if (choice == 13 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(45);
            stress.GetComponent<stressAmount>().addHealth(10);
            timepoints.GetComponent<timePoints>().subtracthours(8);

            Debug.Log("3");

        }
        if (choice == 14 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(50);
            stress.GetComponent<stressAmount>().addHealth(4);
            timepoints.GetComponent<timePoints>().subtracthours(2);

            Debug.Log("4");
        }
        if (choice == 15 && yesno == true)
        {
            food.GetComponent<playerMoney>().subtractMoney(79);
            stress.GetComponent<stressAmount>().addHealth(15);
            timepoints.GetComponent<timePoints>().subtracthours(12);
            Debug.Log("5");

        }
    }
}
