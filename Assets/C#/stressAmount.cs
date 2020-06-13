using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class stressAmount : MonoBehaviour
{
    public Text HealthText;
    int Health = 100;

    // Start is called before the first frame update
    void Start()
    {
        HealthText.text = Health.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = "Hyvinvointi: " + Health.ToString();
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
}
