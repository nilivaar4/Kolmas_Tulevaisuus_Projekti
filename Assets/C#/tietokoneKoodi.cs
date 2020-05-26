using UnityEngine;
using UnityEngine.UI;

public class tietokoneKoodi : MonoBehaviour
{

    public GameObject Panel;

    // Update is called once per frame
    void Update()
    {
    }

    public void ShowPanel()
    {
        Panel.gameObject.SetActive(true);
    }

    public void HidePanel()
    {
        Panel.gameObject.SetActive(false);
    }
}
