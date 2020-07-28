using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class stressAmount : MonoBehaviour
{
    public Text HealthText, endHealthtext;
    public GameObject Screen, Paneeel, caamera;
    int Health = 50;
   // public Renderer colourRenderer;       Trying to get colour to work here

    // Start is called before the first frame update
    void Start()
    {
        HealthText.text = Health.ToString();
        endHealthtext.text = "Voittaessasi pelin, hyvinvointisi oli " + Health.ToString() + "/100";
        //   colourRenderer = GetComponent<Renderer>();     Trying to get colour to work here
    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = "Hyvinvointi: " + Health.ToString() +"/100";  // The chosen "HealthText" shows this
        endHealthtext.text = "Voittaessasi pelin, hyvinvointisi oli " + Health.ToString() + "/100"; // The chosen "endHealthText" shows this
        HealthLimit();
        GameOver();
       // totalHealth();
    }

    //Add health to player
    public void addHealth(int HealthToAdd)
    {
        Health += HealthToAdd;
    }

    //Subtract players health
    public void subtractHealth(int HealthToSubtract)
    {
        Health -= HealthToSubtract;
    }

    //Make sure the Health can't be lower than 0 or higher than 100
    public void HealthLimit()
    {
        if (Health <= 0)
        {
            HealthText.text = "Kuolit Saatana";
        }
        else if (Health >= 100)
        {
            Health = 100;
        }
    }
    //Lose the game if Health is 0 or less
    public void GameOver()
    {
        if (Health <= 0)
        {
            //Enable "game over" screen, and disable the game and it's camer
            Paneeel.gameObject.SetActive(true);
            Screen.gameObject.SetActive(false);
            caamera.gameObject.SetActive(false);


        }
    }

    //Trying to get a colour to change based on the amount of health

   /* public void totalHealth()
    {
        if (Health <= 70)
        {
            colourRenderer.material.color = Color.green;
        }
        else if (Health > 70 && Health <= 30)
        {
            colourRenderer.material.color = Color.yellow;
        }
        else if (Health > 30 && Health <= 10)
        {
            colourRenderer.material.color = Color.red;
        }
    }*/
}
