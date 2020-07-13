using System.Collections;

using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public GameObject ending, maingame, hw;
    public int countdown;
    // Start is called before the first frame update
    void Start()
    {
        countdown = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Limitations();
        gameover();
    }
    public void Limitations()
    {

        if (countdown <= 0)
        {
            countdown = 0;
        }
        else if (countdown >= 3)
        {
            countdown = 3;
        }
    }
    public void gameover()
    {
        if (countdown == 3)
        {
            //häviä peli
            maingame.gameObject.SetActive(false);
            ending.gameObject.SetActive(true);
        }
    }
    public void timer()
    {
        GameObject gradetext = GameObject.Find("gradetext");
        Grade hwgrade = gradetext.GetComponent<Grade>();
        if (hwgrade.grade <= 0)
        {
            countdown += 1;
        }
        else if (hwgrade.grade > 0)
        {
            countdown -= 1;
        }
    }
}
