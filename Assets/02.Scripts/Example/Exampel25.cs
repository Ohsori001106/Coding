using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exampel25 : MonoBehaviour
{
    public int[] N;

    void Start()
    {
        int conut = N.Length;
        for (int i = 0; i < conut; i++)
        {
            Debug.Log(N[i]);
        } 
       
    }


    void Update()
    {
        
    }
}
