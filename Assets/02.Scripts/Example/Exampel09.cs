using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exampel09 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        // 1. 숫자형
        // 1-2.  실수형: 소수점이 있는 숫자
        // float, double, decimal

        float floatValue = 3.141592653559f;   // 7자리 정밀도
        double doubleValue = 3.14159265355216831246814689;     //15자리 정밀도
        decimal decimalValue = 3.14159265355218314317846349m;      //29자리 정밀도

        Debug.Log(floatValue);
        Debug.Log(doubleValue);
        Debug.Log(decimalValue);


        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
