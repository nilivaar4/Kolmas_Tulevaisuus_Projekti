using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class playerMoney : MonoBehaviour
{

    static public int money;
    public Text moneyText;
    // Start is called before the first frame update
    void Start()
    {
        money = 500;
        moneyText.text = money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = money.ToString();

    }
    public void addMoney(int moneyToAdd)
    {
        money += moneyToAdd;
    }

    public void subtractMoney(int moneyToSubtract)
    {
        money -= moneyToSubtract;
    }

}
