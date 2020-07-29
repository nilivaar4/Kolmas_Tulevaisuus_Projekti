using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sleepTimes : MonoBehaviour
{

    public GameObject stress, sleep;
    //"Sleep" for buttons that affects certain things
    public void SleepShort()
    {
        stress.GetComponent<stressAmount>().subtractHealth(10);
        sleep.GetComponent<timePoints>().subtracthours(180);
    }

    public void SleepMedium()
    {
        sleep.GetComponent<timePoints>().subtracthours(240);
    }

    public void SleepLong()
    {
        stress.GetComponent<stressAmount>().addHealth(10);
        sleep.GetComponent<timePoints>().subtracthours(300);
    }
}
