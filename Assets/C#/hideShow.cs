using UnityEngine;
using UnityEngine.UI;

public class hideShow : MonoBehaviour
{

    public GameObject Paneel;

    // Update is called once per frame
    void Update()
    {
    }

    public void ShowPanel()
    {
        Paneel.gameObject.SetActive(true);
    }

    public void HidePanel()
    {
        Paneel.gameObject.SetActive(false);
    }
}
