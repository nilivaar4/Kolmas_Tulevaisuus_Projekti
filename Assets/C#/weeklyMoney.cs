using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weeklyMoney : MonoBehaviour
{
   
    public GameObject week, health;
    public int rentprice, electro, insurance;

    // The money gained and lost when this is called
    public void Moneys()
    {        

        week.GetComponent<playerMoney>().addMoney(100);
        week.GetComponent<playerMoney>().subtractMoney(rentprice + electro + insurance);
        health.GetComponent<stressAmount>().subtractHealth(15);

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
    public void Electricity1()
    {
        electro = 31;
    }
    public void Electricity2()
    {
        electro = 42;
    }
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
}
