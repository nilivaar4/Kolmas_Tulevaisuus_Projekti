using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class timeMonth : MonoBehaviour
{
    string[] names = DateTimeFormatInfo.CurrentInfo.MonthNames;
    public Text timeText;
    int i = 0;

    void Start()
    {
        names[0] = "Tammikuu";
        names[1] = "Helmikuu";
        names[2] = "Maaliskuu";
        names[3] = "Huhtikuu";
        names[4] = "Toukokuu";
        names[5] = "Kesäkuu";
        names[6] = "Heinäkuu";
        names[7] = "Elokuu";
        names[8] = "Syyskuu";
        names[9] = "Lokakuu";
        names[10] = "Marraskuu";
        names[11] = "Joulukuu";

        timeText.text = names[0];


    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Months()
    {
        if (i < 11)
        {
            i++;
            Debug.Log(names[i]);
            timeText.text = names[i];
        }

        else
        {
            i = 0;
            timeText.text = names[i];

        }
    }


    } 

