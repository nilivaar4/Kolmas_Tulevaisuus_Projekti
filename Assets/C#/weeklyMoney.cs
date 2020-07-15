using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weeklyMoney : MonoBehaviour
{
   
    public GameObject week, health, timepoints, hw;
    public int rentprice, electro, insurance, work, workstress, wifi;
    public bool loan, studymoney, housemoney, job1, job2, job3, grade;
    


    void Start()
    {
        work = 0;
        workstress = 0;
        loan = false;
        studymoney = false;
        housemoney = false;
        job1 = false;
        job2 = false;
        job3 = false;
        grade = false;
    }

    void Update()
    {
        worksituation();
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
        timepoints.GetComponent<timePoints>().addhours(560);

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
    public void plan1()
    {
        wifi = 9;
    }
    public void plan2()
    {
        wifi = 20;
    }
    public void plan3()
    {
        wifi = 32;
    }
    //The chosen job
    public void Job1()
    {
        job1 = true;
        job2 = false;
        job3 = false;      
        work = 1920;
        workstress = 10;
    }
    public void Job2()
    {
        job1 = false;
        job2 = true;
        job3 = false;        
        work = 960;
        workstress = 5;
    }
    public void Job3()
    {
        job1 = false;
        job2 = false;
        job3 = true;
        work = 320;
    }

    public void worksituation()
    {
        if (job1 == true)
        {
            housemoney = false;
            studymoney = false;
        }
        if (job2 == true)
        {
            studymoney = false;
        }
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

    public void homework1()
    {
        hw.GetComponent<Grade>().lowerGrade(1);
        grade = true;
        timepoints.GetComponent<timePoints>().subtracthours(20);
    }
    public void homework2()
    {
        grade = true;
        timepoints.GetComponent<timePoints>().subtracthours(40);
    }

    public void homework3()
    {
        hw.GetComponent<Grade>().raiseGrade(1);
        grade = true;
        timepoints.GetComponent<timePoints>().subtracthours(60);
    }
    public void checkhw()
    {
        if (grade == false)
        {
            hw.GetComponent<Grade>().lowerGrade(2);
            
        }
        else
        {
            grade = false;
        }
    }
}

