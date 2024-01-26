using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public int A;
    public int B;
    public int C;

    void Start()
    {
        C = A;
        A = B;
        B = C;
        
        Debug.Log(A);
        Debug.Log(B);
    }


    void Update()
    {
        
    }
}
