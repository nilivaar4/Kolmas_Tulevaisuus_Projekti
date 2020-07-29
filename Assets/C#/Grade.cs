using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Grade : MonoBehaviour
{
    public int grade, countdown;
    public Text gradeText, endgradeText, gogradeText;
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
        //Change the texts based on your grade
        gradeText.text = "Keskiarvosi on " + grade.ToString();
        endgradeText.text = "Voittaessasi pelin, arvosanasi oli " + grade.ToString() + "/5";
        gogradeText.text = "Hävitessäsi pelin, arvosanasi oli " + grade.ToString() + "/5";
        if (gogradeText.text == "Hävitessäsi pelin, arvosanasi oli -2/5") //Hardcoded is like this, because couldn't find a better solution in a short time
        {                                                                  //Basically you lose -2 grade every "turn" if you don't do school stuff, and that's why this works.
            gogradeText.text = "Hävisit pelin, koska arvosanasi oli 0 liian kauan.";
        }
        Limitations();
        //gameover();
    }


    //Raise players grade
    public void raiseGrade(int raise)
    {
        grade += raise;
    }

    //Lower players grade
    public void lowerGrade(int lower)
    {
        grade -= lower;
    }

    //Force the grade to stay between the limits
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
    //Attempt at making gameover inside this script
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

    //How much time spent on homework. For Buttons
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
