using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test36 : MonoBehaviour
{
    public string Str = "54321";

    void Start()
    {


        int num =int.Parse(Str);
        int sum = SumSum(Str);

        // 결과 출력
        Debug.Log(sum);
    }

    
    int SumSum(string numbers)
    {
        int sum = 0;

        
        for (int i = 0; i < numbers.Length; i++)
        {
            int nums = int.Parse(numbers[i].ToString());
            
            sum += nums;

        }

        return sum;
    }

    
    void Update()
    {
        
    }
}
