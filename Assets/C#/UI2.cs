using System.Collections;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class UI2 : MonoBehaviour
{
    public Text loantext, studytext, housetext, wagetext;
 

    //This changes the texts in the bottom right square of the game
    public void economictexts()
    {
        GameObject economies = GameObject.Find("Door button");
        weeklyMoney weeklymoney = economies.GetComponent<weeklyMoney>();
        if (weeklymoney.loan == false)
        {
            loantext.text = "Opintolaina: Ei";
        }
        else if (weeklymoney.loan == true)
        {
            loantext.text = "Opintolaina: 650€/kk";
        }
        if (weeklymoney.studymoney == false)
        {
            studytext.text = "Opintoraha: Ei";
        }
        else if (weeklymoney.studymoney == true)
        {
            studytext.text = "Opintolaina: 253€/kk";
        }
        if (weeklymoney.housemoney == false)
        {
            housetext.text = "Asumistuki: Ei";
        }
        else if (weeklymoney.housemoney == true && weeklymoney.rentprice == 277)
        {
            housetext.text = "Asumistuki: 236€/kk";
        }
        else if (weeklymoney.housemoney == true && weeklymoney.rentprice == 542)
        {
            housetext.text = "Asumistuki: 320€/kk";
        }
        else if (weeklymoney.housemoney == true && weeklymoney.rentprice == 450)
        {
            housetext.text = "Asumistuki: 320€/kk";
        }        

        if (weeklymoney.job1 == true)
        {
            wagetext.text = "Palkka: 1920€/kk";
        }
        else if (weeklymoney.job2 == true)
        {
            wagetext.text = "Palkka: 960€/kk";
        }
        else if (weeklymoney.job3 == true)
        {
            wagetext.text = "Palkka: 320€/kk";
        }
        else if (weeklymoney.job3 == false && weeklymoney.job3 == false && weeklymoney.job3 == false)
        {
            wagetext.text = "Et ole töissä.";
        }
    }
    // Update is called once per frame
    void Update()
    {
        economictexts();
    }

    
}
