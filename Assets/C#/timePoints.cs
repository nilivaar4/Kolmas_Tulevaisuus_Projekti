using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class timePoints : MonoBehaviour
{
    public Text hoursText;
    int hours;
    public GameObject button1, button2, button3, screen1, screen2, screen3, caamera, doorbutton;
    // Start is called before the first frame update
    void Start()
    {
        hours = 560;
        hoursText.text = hours.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        hoursText.text = hours.ToString() + " tuntia käytössä";
        Limitations();
        ButtonsOff();
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

    public void ButtonsOff()
    {
        /*if (hours <= 0 && button1.activeSelf)
        {
            button1.gameObject.SetActive(false);
            if (screen1.activeSelf)
            {
                screen1.gameObject.SetActive(false);
                caamera.gameObject.SetActive(true);
            }
        }
        else if (hours >= 0 && !button1.activeSelf)
        {
            button1.gameObject.SetActive(true);
        }*/
        if (hours <= 0 && button2.activeSelf)
        {
            button2.gameObject.SetActive(false);
            if (screen2.activeSelf)
            {
                screen2.gameObject.SetActive(false);
                caamera.gameObject.SetActive(true);
            }
        }
        else if (hours >= 0 && !button2.activeSelf)
        {
            //button2.gameObject.SetActive(true);
        }
        if (hours <= 0 && button3.activeSelf)
        {
            button3.gameObject.SetActive(false);
            if (screen3.activeSelf)
            {
                screen3.gameObject.SetActive(false);
                caamera.gameObject.SetActive(true);
            }
        }
        else if (hours >= 0 && !button3.activeSelf)
        {
            //button3.gameObject.SetActive(true);
        }
        if (hours == 0 && !doorbutton.activeSelf)
        {
            doorbutton.gameObject.SetActive(true);
        }
    }


    public void Limitations()
    {
        if (hours <= 0)
        {
            hoursText.text = "0 Tuntia käytössä";
            hours = 0;
        }
        if (hours >= 560)
        {
            hours = 560;
            hoursText.text = hours.ToString() + " tuntia käytössä";

        }
        /*else if (hours >= 0)
        {
            hoursText.text = hours.ToString() + " tuntia käytössä";

        }*/
        
    }
}
