using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class shutdown : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //Game Shuts down when "esc" is pressed.
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        
    }
    //Shutdown for a button

    /*public void Shutdown()
    {      
        Application.Quit();       
    }*/
}
