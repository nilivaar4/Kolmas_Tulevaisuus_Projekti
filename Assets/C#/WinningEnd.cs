﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningEnd : MonoBehaviour
{
    public int final_countdown = 0;
    public GameObject game, ending, cameraa;


    // Update is called once per frame
    void Update()
    {
        won_the_game();
    }
    
    //When called you get 1 closer to the "won_the_game"
    public void survived()
    {
        final_countdown += 1;
    }

    public void won_the_game()  //Game ends by hiding game elements, and showing the "Winning"-screenm when "survived()" is called 24 times.
    {
        if(final_countdown == 6)
        {
            game.gameObject.SetActive(false);
            cameraa.gameObject.SetActive(false);
            ending.gameObject.SetActive(true);
        }
    }
}
