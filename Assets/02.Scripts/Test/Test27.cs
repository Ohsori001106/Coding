using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Test27 : MonoBehaviour
{
    public int[] A;
    void Start()
    {
        int index = 0;
        int max = A[0];

        for (int i = 0; i < A.Length; i++)
        {
            if (max > A[i]) 
            {
                continue;
            }

            max = A[i];
            index = i;
        }


      

        Debug.Log(max);
        Debug.Log(index + 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
