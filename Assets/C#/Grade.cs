using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Grade : MonoBehaviour
{
    public int grade;
    public Text gradeText;
    // Start is called before the first frame update
    void Start()
    {
        grade = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        gradeText.text = "Keskiarvosi on " + grade.ToString();
        Limitations();
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
    }
}
