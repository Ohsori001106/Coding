using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test07 : MonoBehaviour
{
    public int A;
    public int B;
    public int C;

    void Start()
    {

        int a = A;
        int b = B;
        int c = C;


        if (A < B)
        {
            if (B < C)
            {
                Debug.Log($"{a},{b},{c}");
            }
            else if (A > C)
            {
                Debug.Log($"{c},{a},{b}");
            }
            else if (C < B)
            {
                Debug.Log($"{a},{c},{b}");
            }
        }

        else if (B < A)
        {
            if (A < C)
            {
                Debug.Log($"{b},{a},{c}");
            }
            else if (C < B)
            {
                Debug.Log($"{c},{b},{a}");
            }
            else if (C < A)
            {
                Debug.Log($"{b},{c},{a}");
            }
            
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
