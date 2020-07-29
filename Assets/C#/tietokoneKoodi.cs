using UnityEngine;
using UnityEngine.UI;

public class tietokoneKoodi : MonoBehaviour
{

    public GameObject Panel;

    //Simple script for hiding and showing a certain thing

    public void ShowPanel()
    {
        Panel.gameObject.SetActive(true);
    }

    public void HidePanel()
    {
        Panel.gameObject.SetActive(false);
    }
}
