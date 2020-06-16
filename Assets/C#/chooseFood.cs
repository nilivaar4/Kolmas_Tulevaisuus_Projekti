using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseFood : MonoBehaviour
{

    public GameObject food;
    //public int pirkka, pirkkaParhaat;
    //public int cost = 0;


    public void Food1()
    {
        food.GetComponent<playerMoney>().subtractMoney(10);

    }

    public void Food2()
    {
        food.GetComponent<playerMoney>().subtractMoney(15);


    }
    public void Food3()
    {
        food.GetComponent<playerMoney>().subtractMoney(25);


    }
    public void Food4()
    {
        food.GetComponent<playerMoney>().subtractMoney(35);


    }
    public void Food5()
    {

        food.GetComponent<playerMoney>().subtractMoney(45);

    }

}
