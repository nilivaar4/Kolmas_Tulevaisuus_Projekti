using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class chooseFood : MonoBehaviour
{

    public GameObject food, stress;
    //public int pirkka, pirkkaParhaat;
    public int rngHP;
    System.Random rnd = new System.Random();

    //public int cost = 0;

    void Update()
    {
        rngHP = rnd.Next(1, 21);

    }

    public void Food1()
    {
        food.GetComponent<playerMoney>().subtractMoney(10);
        stress.GetComponent<stressAmount>().subtractHealth(rngHP);

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
