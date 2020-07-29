using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class chooseFood : MonoBehaviour
{

    public GameObject food, stress;
    //public int pirkka, pirkkaParhaat;
    public int rngHP, smallrng, cheaprng, mediumrng, expensiverng;
    System.Random rnd = new System.Random();

    //public int cost = 0;

    void Update()
    {
           //Bunch of random ints for the amount of health gained and money spent
        rngHP = rnd.Next(5, 21);
        smallrng = rnd.Next(1, 3);
        cheaprng = rnd.Next(50, 101);
        mediumrng = rnd.Next(150, 201);
        expensiverng = rnd.Next(275, 400);
    }
    //The chosen food as a button
    public void Food1()
    {
        food.GetComponent<playerMoney>().subtractMoney(cheaprng);
        stress.GetComponent<stressAmount>().subtractHealth(rngHP);

    }

    public void Food2()
    {
        food.GetComponent<playerMoney>().subtractMoney(mediumrng);


    }
    public void Food3()
    {
        food.GetComponent<playerMoney>().subtractMoney(expensiverng);
        stress.GetComponent<stressAmount>().addHealth(rngHP - 4);

    }
    public void Food4()
    {
        food.GetComponent<playerMoney>().subtractMoney(20);
        stress.GetComponent<stressAmount>().addHealth(smallrng);


    }
    public void Food5()
    {

        food.GetComponent<playerMoney>().subtractMoney(45);

    }

}
