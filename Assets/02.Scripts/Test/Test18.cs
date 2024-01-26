using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test18 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        int C = 1;
        for (int i = 2; i <= 9; i++)
        {
            for (int I = 1; I <= 9; I++)
            {
                
                C = i * I;

                Debug.Log($"{i}*{I}={C}");
            }
            Debug.Log("------------");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
