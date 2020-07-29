using UnityEngine;
using UnityEngine.UI;

public class kaakelinKela : MonoBehaviour
{

    public GameObject Paneel;

  //Simple script to hide and show a certain thing

    public void ShowPanel()
    {
        Paneel.gameObject.SetActive(true);
    }

    public void HidePanel()
    {
        Paneel.gameObject.SetActive(false);
    }
}
