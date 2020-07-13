using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Grade : MonoBehaviour
{
    public int grade, countdown;
    public Text gradeText;
    public bool effort;
    //public GameObject ending, maingame;
    // Start is called before the first frame update
    void Start()
    {
        grade = 3;
        effort = false;
        //countdown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gradeText.text = "Keskiarvosi on " + grade.ToString();
        Limitations();
        //gameover();
    }
    


    public void raiseGrade(int raise)
    {
        grade += raise;
    }

    //Subtract players money
    public void lowerGrade(int lower)
    {
        grade -= lower;
    }

    public void Limitations()
    {
        if (grade <= 0)
        {
            grade = 0;
        }
        else if (grade >= 5)
        {
            grade = 5;
        }

        if (countdown <= 0)
        {
            countdown = 0;
        }
        else if (countdown >= 3)
        {
            countdown = 3;
        }
    }
    /*public void gameover()
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
        if (grade <= 0)
        {
            countdown += 1;
        }
        else if (grade > 0)
        {
            countdown -= 1;
        }
    }*/

    public void hw1()
    {
        lowerGrade(1);
        effort = true;
    }
    public void hw2()
    {
        effort = true;
    }
    public void hw3()
    {
        raiseGrade(1);
        effort = true;
    }   
}
