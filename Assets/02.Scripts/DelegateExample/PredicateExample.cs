using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PredicateExample : MonoBehaviour
{
    
    void Start()
    {

        // Func<T1,T2,...,TResult>
        // 입력: T 타입
        // 반환: TResult
        // 반드시 반환값 bool 형식이고, 매개 변수의 개수를 0~16개인 매서드를 담을 수 있는 대리자
        Predicate<int> a = IsOdd;
        Debug.Log(a(17));
    }
    bool IsOdd(int num)
    {
        return num % 2 == 1;
    }
   
    void Update()
    {
        
    }
}
