using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Exampel36 : MonoBehaviour
{
    // 반환 데이터가 없는 경우는 : void
    public int Num1;
    void Hello()
    {
        return; // 반환 데이터가 없는 함수의 경우 return만 호출해서
                // 함수 중간에 종료 용도로 사용 가능하다.
        Debug.Log("Hello");
    }
    bool IsOdd(int num1)
    {

        if (num1 % 2 == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Q. 매개변수로 정수를 하나 입력 받아서 홀수이면 true 짝수이면 false를 반환하는 함수
    // 함수명: IsOdd
    
    // 함수를 만들 때 4가지 경우의 수
    // 1. 반환 데이터가 있고, 매개 변수도 있는 함수        // int Sum(int, int)
    // 2. 반환 데이터 없고(void), 매개 변수 있는 함수      // void Test(int)
    // 3. 반환 데이터 있고, 매개 변수 없는 함수            // int GetLengt()
    // 4. 반환 데이터 없고(void), 매개 변수 없는 함수      // void Hello()

    
    void Start()
    {
        //Hello();

        // 3
        // Debug.Log(뭐시기) -> false
       Debug.Log(IsOdd(Num1));
        
        for (int i = 1; i <= 100; i++)
        {
            // 만약 (홀수냐(i)? == true)
            if (IsOdd(i)==true)
            {
                Debug.Log(i);
            }
        }
        
    }

    
    // Q. 매개변수로 정수를 하나 입력 받아서 짝수이면 true 홀수이면 false를 반환하는 함수
    // 함수명: IsOdd

    // Update is called once per frame
    void Update()
    {
        
    }
}
