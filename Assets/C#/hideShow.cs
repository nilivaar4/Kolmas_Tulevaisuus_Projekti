using UnityEngine;
using UnityEngine.UI;

public class hideShow : MonoBehaviour
{

    public GameObject Paneel;

   //Simple script for buttons that hide or show certain thing

    public void ShowPanel()
    {
        Paneel.gameObject.SetActive(true);
    }

    public void HidePanel()
    {
        Paneel.gameObject.SetActive(false);
    }
}
