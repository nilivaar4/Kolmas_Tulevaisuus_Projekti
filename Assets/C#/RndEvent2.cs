using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RndEvent2 : MonoBehaviour
{
    public GameObject rnd;

    System.Random rng = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextRnd()
    {
        GameObject rnd = GameObject.Find("yesnoc#");
        randomEvent randomevent = rnd.GetComponent<randomEvent>();
        randomevent.choice = rng.Next(1, 6);
        randomevent.yesno = false;

    }
    

}
