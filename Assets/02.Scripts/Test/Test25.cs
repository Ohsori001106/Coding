using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test25 : MonoBehaviour
{
    public int[] A;

    void Start()
    {
        int min = A[0];
        int max = A[0];

        for (int i = 0; i < A.Length; i++)
        {
            if (min < A[i] )
            {
                continue;
            }
            min = A[i];
        }

        for (int i = 0; i < A.Length; i++)
        {
            if (max > A[i])
            {
                continue;
            }
            max = A[i];
        }
        Debug.Log($"{min}  {max}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
