using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test24 : MonoBehaviour
{
    public int[] A;
    public int X;
    void Start()
    {
        string result = "  ";

        for (int i = 0; i < A.Length; i++)
        {

            if (A[i] < X)
            {
                result += A[i] +"  ";
            }

        }

        Debug.Log(result);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
