using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class stressAmount : MonoBehaviour
{
    public Text HealthText, endHealthtext;
    public GameObject Screen, Paneeel, caamera;
    int Health = 50;
   // public Renderer colourRenderer;

    // Start is called before the first frame update
    void Start()
    {
        HealthText.text = Health.ToString();
        endHealthtext.text = "Voittaessasi pelin, hyvinvointisi oli " + Health.ToString() + "/100";
        //   colourRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = "Hyvinvointi: " + Health.ToString();
        endHealthtext.text = "Voittaessasi pelin, hyvinvointisi oli " + Health.ToString() + "/100";
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
    public void GameOver()
    {
        if (Health <= 0)
        {
            Paneeel.gameObject.SetActive(true);

            Screen.gameObject.SetActive(false);
            caamera.gameObject.SetActive(false);


        }
    }
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
