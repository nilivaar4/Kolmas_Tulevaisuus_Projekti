using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weeklyMoney : MonoBehaviour
{
   
    public GameObject week, health, timepoints;
    public int rentprice, electro, insurance, work, workstress;
    public bool loan, studymoney, housemoney;
    


    void Start()
    {
        work = 0;
        workstress = 0;
        loan = false;
        studymoney = false;
        housemoney = false;
    }

    void Update()
    {
        if(studymoney == false)
        {
            loan = false;
        }
    }

    // The money gained and lost when this is called
    public void Moneys()
    {

        week.GetComponent<playerMoney>().addMoney(work);
        week.GetComponent<playerMoney>().subtractMoney(rentprice + electro + insurance);
        health.GetComponent<stressAmount>().subtractHealth(10 + workstress);
        timepoints.GetComponent<timePoints>().addhours(720);

        if(studymoney==true)
        {
            week.GetComponent<playerMoney>().addMoney(253);
        }
        if (housemoney == true && rentprice == 277)
        {
            week.GetComponent<playerMoney>().addMoney(236);
        }
        if (housemoney == true && rentprice == 542)
        {
            week.GetComponent<playerMoney>().addMoney(320);
        }
        if (housemoney == true && rentprice == 450)
        {
            week.GetComponent<playerMoney>().addMoney(320);
        }
        if (loan == true)
        {
            week.GetComponent<playerMoney>().addMoney(650);
        }
    }

    // The rent of the apartment you choose with the toggle buttons.
    public void toggle1()
    {
        rentprice = 277;
    }

    public void toggle2()
    {
        rentprice = 450;
    }

    public void toggle3()
    {
        rentprice = 542;
    }

    //The chosen electricity plan
    public void Electricity1()
    {
        electro = 31;
    }
    public void Electricity2()
    {
        electro = 42;
    }

    //The chosen insurance
    public void insurance1()
    {
        insurance = 5;
    }
    public void insurance2()
    {
        insurance = 7;
    }
    public void insurance3()
    {
        insurance = 9;
    }

    //The chosen job
    public void Job1()
    {
        housemoney = false;
        studymoney = false;
        work = 1920;
        workstress = 10;
    }
    public void Job2()
    {
        studymoney = false;
        work = 960;
        workstress = 5;
    }
    public void Job3()
    {
        work = 320;
    }

    public void getLoan()
    {
        loan = true;
    }
    public void studentMoney()
    {
        studymoney = true;
    }
    public void houseMoney()
    {
        housemoney = true;
    }
}
