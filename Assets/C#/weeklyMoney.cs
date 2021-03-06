﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class weeklyMoney : MonoBehaviour
{
   
    public GameObject week, health, timepoints, hw;
    public int rentprice, electro, insurance, work, workstress, wifi, workhours, everything, home1, home2, electro1, plans1, plans2, network, networkplan;
    public bool loan, studymoney, housemoney, job1, job2, job3, grade;
    public Text debts;


    void Start()
    {
        //These could be useless, idk
        work = 0;
        workstress = 0;
        loan = false;
        studymoney = false;
        housemoney = false;
        job1 = false;
        job2 = false;
        job3 = false;
        grade = false;
        everything = rentprice + electro + insurance + wifi;
    }

    void Update()
    {
        worksituation();
        
        if(studymoney == false)
        {
            loan = false; //Can't have loan, if you don't have the "studymoney"
        }
        everything = rentprice + electro + insurance + wifi + network;
        debts.text = "Kuukausittaiset kulut: " + everything.ToString() + "€"; 
    }
    

    
    public void Moneys() //The script for a button that makes you lose and gain money, health, and timepoints based on choices you have made. The choices are defined by functions below.
    {

        week.GetComponent<playerMoney>().addMoney(work);
        week.GetComponent<playerMoney>().subtractMoney(rentprice + electro + insurance + wifi + network);
        health.GetComponent<stressAmount>().subtractHealth(15 + workstress + home1 + plans1);
        health.GetComponent<stressAmount>().addHealth(home2 + electro1 + plans2 + networkplan);
        timepoints.GetComponent<timePoints>().addhours(560);
        //timepoints.GetComponent<timePoints>().subtracthours(workhours);

        if (studymoney==true)
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
        home1 = 5;
    }

    public void toggle2()
    {
        rentprice = 450;
    }

    public void toggle3()
    {
        rentprice = 542;
        home2 = 5;
    }

    //The chosen electricity plan
    public void Electricity1()
    {
        electro = 31;
    }
    public void Electricity2()
    {
        electro = 42;
        electro1 = 3;
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
    //The chosen phone plan thingy
    public void plan1()
    {
        wifi = 9;
        plans1 = 5;
    }
    public void plan2()
    {
        wifi = 20;
    }
    public void plan3()
    {
        wifi = 32;
        plans2 = 5;
    }
    public void networkplan1()
    {
        network = 0;
        
    }
    public void networkplan2()
    {
        network = 0;
        networkplan = 2;
    }
    public void networkplan3()
    {
        network = 10;
        networkplan = 4;
    }
    //The chosen job
    public void Job1()
    {
        job1 = true;
        job2 = false;
        job3 = false;      
        work = 1920;
        workstress = 15;
        workhours = 160;
    }
    public void Job2()
    {
        job1 = false;
        job2 = true;
        job3 = false;        
        work = 960;
        workstress = 10;
        workhours = 120;
    }
    public void Job3()
    {
        job1 = false;
        job2 = false;
        job3 = true;
        work = 320;
        workhours = 32;
        workstress = 5;
    }
    public void NoJob()
    {
        job1 = false;
        job2 = false;
        job3 = false;
        work = 0;
        workhours = 0;
        workstress = 0;
    }

    //Can't have certain things if you have a certain job
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
    //Simple functions for buttons
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
    //Doing homework, and how it affects.
    public void homework1()
    {
        hw.GetComponent<Grade>().lowerGrade(1);
        grade = true;
        timepoints.GetComponent<timePoints>().subtracthours(20);
    }
    public void homework2()
    {
        grade = true;
        timepoints.GetComponent<timePoints>().subtracthours(60);
    }

    public void homework3()
    {
        hw.GetComponent<Grade>().raiseGrade(1);
        grade = true;
        timepoints.GetComponent<timePoints>().subtracthours(120);
    }
    //Check if player has done homework
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

