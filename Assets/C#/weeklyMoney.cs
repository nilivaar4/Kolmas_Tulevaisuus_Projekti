using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weeklyMoney : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject week;


    public void Moneys()
    {
        week.GetComponent<playerMoney>().addMoney(100);
    }


}
