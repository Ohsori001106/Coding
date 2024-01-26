using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test13 : MonoBehaviour
{
    public int Dice1;
    public int Dice2;
    public int Dice3;
    // Start is called before the first frame update
    void Start()
    {
        int reward = 0;

        if ((Dice1 == Dice2) && (Dice2 == Dice3))
        {
             reward = 10000 + Dice1 * 1000;
        }
        if ((Dice1 == Dice2) || (Dice1 == Dice3)||(Dice2 == Dice3))
        {
            if (Dice1 == Dice2)
            {
                 reward = 1000 + Dice1 * 100;
            }
            if (Dice2 == Dice3)
            {
                 reward = 1000 + Dice2 * 100;
            }
            if (Dice1 == Dice3)
            {
                 reward = 1000 + Dice3 * 100;
            }
        }
        else
        {
            if (Dice1 > Dice2 && Dice1 > Dice3)
            {
                 reward = Dice1 * 100;
            }
            if (Dice2 > Dice1 && Dice2 > Dice3)
            {
                 reward = Dice2 * 100;
            }
            if (Dice3 > Dice1 && Dice3 > Dice2)
            {
                 reward = Dice3 * 100;
            }
        }
        Debug.Log(reward);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
