using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weeklyMoney : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject week;
    public int rentprice;

    public void Moneys()
    {
        //rentprice = week.GetComponent<houseRent>().rent;

        week.GetComponent<playerMoney>().addMoney(100);
        week.GetComponent<playerMoney>().subtractMoney(13);

    }


}
