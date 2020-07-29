using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class playerMoney : MonoBehaviour
{

    static public int money;
    public Text moneyText, endmoneyText, gomoneyText;
    public GameObject Screen, Paneeel, caamera;
    // Start is called before the first frame update
    void Start()
    {
        money = 1000;   //The amount of money, the player starts with.
        moneyText.text = money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = money.ToString() + "€";
        endmoneyText.text = "Voittaessasi pelin, rahaa sinulla oli " + money.ToString() + "€";
        gomoneyText.text = "Hävitessäsi pelin, rahaa sinulla oli " + money.ToString() + "€";
        Limitations();
        GameOver();
    }


    //Game over if your money hits 0
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

    //Limits the amount of money you can have
    public void Limitations()
    {
        if (money <= 0)
        {
            gomoneyText.text = "Hävisit koska rahasi loppuivat";
            money = 0;
        }
        else if (money >= 0)
        {
            moneyText.text = money.ToString() + "€";
        }
    }

}
