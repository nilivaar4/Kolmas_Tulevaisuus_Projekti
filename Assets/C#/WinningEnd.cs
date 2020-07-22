using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningEnd : MonoBehaviour
{
    public int final_countdown = 0;
    public GameObject game, ending, cameraa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        won_the_game();
    }
    
    public void survived()
    {
        final_countdown += 1;
    }

    public void won_the_game()
    {
        if(final_countdown == 24)
        {
            game.gameObject.SetActive(false);
            cameraa.gameObject.SetActive(false);
            ending.gameObject.SetActive(true);
        }
    }
}
