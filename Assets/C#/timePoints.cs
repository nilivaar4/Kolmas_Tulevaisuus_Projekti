using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class timePoints : MonoBehaviour
{
    public Text hoursText;
    int hours;
    // Start is called before the first frame update
    void Start()
    {
        hours = 720;
        hoursText.text = hours.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        hoursText.text = hours.ToString() + " tuntia käytössä";
        Limitations();
    }

    //Add money to player
    public void addhours(int hoursToAdd)
    {
        hours += hoursToAdd;
    }

    //Subtract players money
    public void subtracthours(int hoursToSubtract)
    {
        hours -= hoursToSubtract;
    }

    public void Limitations()
    {
        if (hours <= 0)
        {
            hoursText.text = "0 Tuntia käytössä";
            hours = 0;
        }
        else if (hours >= 720)
        {
            hours = 720;
            hoursText.text = hours.ToString() + " tuntia käytössä";

        }
        else if (hours >= 0)
        {
            hoursText.text = hours.ToString() + " tuntia käytössä";

        }
        
    }
}
