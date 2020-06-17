﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class stressAmount : MonoBehaviour
{
    public Text HealthText;
    public GameObject Screen, Paneeel, caamera;
    int Health = 50;

    // Start is called before the first frame update
    void Start()
    {
        HealthText.text = Health.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = "Hyvinvointi: " + Health.ToString();
        HealthLimit();
        GameOver();
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
}
