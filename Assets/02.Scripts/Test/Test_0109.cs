using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test_0109 : MonoBehaviour
{
    
    public int Num1;
    public int Num2;
    public int Num3;
    
    
    // Q1. 정수 2개를 매개변수로 넘겨받아 두 수중 더 큰 수를 반환하는 함수를 만들고 테스트
     int ToBig( int num1, int num2)  // 여기까지가 함수 선언부
    {
        int bigNum =0;
        if (num1 > num2)
        {
            bigNum = num1;
        }
        else if (num2 > num1)
        { 
            bigNum = num2;
        }
      
        return bigNum;

        // if (num1 > num2)
        // {
        // return num1;
        // }
        // return num2;
    }
    // Q2. 정수 3개를 매개변수로 넘겨받아 평균을 구해 반환하는 함수를 만들고 테스트 ( 평균점은 소수점이 있음)

    float Average(int num1, int num2, int num3)
    {
        
        float average = (num1 + num2 + num3) / 3f;
        return average;
    }
    // Q3. 정수값을 입력받아 0부터 해당 정수값까지 출력해 주는 함수를 만들고 테스트 (반환안함)
    void LogNums(int num)
    {
        for (int i = 0; i <= Num1; i++)
        {
            Debug.Log(i);
        }
    }

    void Start()
    {
        // 호출: 함수이름(매개변수)
        Debug.Log(4);

        // Q1.답
        int Comparison = ToBig(Num1, Num2);
        Debug.Log(Comparison);
        Debug.Log(ToBig(Num1, Num2));
        Debug.Log(Mathf.Max(Num1, Num2));
        // Q2.답
        float average = Average(Num1,Num2,Num3);
        Debug.Log(average);
        Debug.Log(Average(Num1,Num2,Num3));
        // Q3.답
        LogNums(Num1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
