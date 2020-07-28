﻿using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class playerMoney : MonoBehaviour
{

    static public int money;
    public Text moneyText, endmoneyText;
    public GameObject Screen, Paneeel, caamera;
    // Start is called before the first frame update
    void Start()
    {
        money = 2000;
        moneyText.text = money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = money.ToString() + "€";
        endmoneyText.text = "Voittaessasi pelin, rahaa sinulla oli " + money.ToString() + "€";
        Limitations();
        GameOver();
    }
    public void GameOver()
    {
        if (money <= 0)
        {
            Paneeel.gameObject.SetActive(true);

            Screen.gameObject.SetActive(false);
            caamera.gameObject.SetActive(false);


        }
    }
    //Add money to player
    public void addMoney(int moneyToAdd)
    {
        money += moneyToAdd;
    }

    //Subtract players money
    public void subtractMoney(int moneyToSubtract)
    {
        money -= moneyToSubtract;
    }

    public void Limitations()
    {
        if (money <= 0)
        {
            moneyText.text = "0€";
            money = 0;
        }
        else if (money >= 0)
        {
            moneyText.text = money.ToString() + "€";
        }
    }

}
