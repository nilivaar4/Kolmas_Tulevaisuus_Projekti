using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class houseRent : MonoBehaviour
{
    public int rent;
    // Start is called before the first frame update
    void Start()
    {
           rent = 0;
    }

// Update is called once per frame
    void Update()
    {
        
    }

    public void toggle1()
    {
        rent = 10;
    }

    public void toggle2()
    {
        rent = 20;
    }

    public void toggle3()
    {
        rent = 30;
    }

    public void payRent(int rental)
    {
        rent = rental;
    }
}
