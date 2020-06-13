using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weeklyMoney : MonoBehaviour
{
   
    public GameObject week;
    public int rentprice;

    // The money gained and lost when this is called
    public void Moneys()
    {        

        week.GetComponent<playerMoney>().addMoney(100);
        week.GetComponent<playerMoney>().subtractMoney(rentprice);

    }

    // The rent of the apartment you choose with the toggle buttons.
    public void toggle1()
    {
        rentprice = 10;
    }

    public void toggle2()
    {
        rentprice = 20;
    }

    public void toggle3()
    {
        rentprice = 30;
    }


}
