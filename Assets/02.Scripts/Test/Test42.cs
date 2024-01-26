using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test42 : MonoBehaviour
{
    public int[] Chess;
    void Start()
    {
        int[] unit = { 1, 1, 2, 2, 2, 8 };
        int[] result = new int[6];
        string array = "";
        
        for (int i = 0; i < Chess.Length; i++)
        {
            result[i] = unit[i] - Chess[i];
            
            array += result[i] + " ";
        }
        
       
        Debug.Log(array);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
