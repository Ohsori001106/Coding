using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exampel08 : MonoBehaviour
{
    // c# 에서 기본으로 제공하는 데이터 타입은 16가지
    // 1.숫자형
    // 1-1. 정수형:
    // byte, short, int, long

    

    void Start()
    {
        sbyte sbyteValue = 3;
        short shortValue = 3;
        int intValue = 3;
        long longValue = 3;

        Debug.Log(byte.MinValue);
        Debug.Log(byte.MaxValue);

        Debug.Log(short.MinValue);
        Debug.Log(short.MaxValue);

        Debug.Log(int.MinValue);
        Debug.Log(int.MaxValue);

        Debug.Log(long.MinValue);
        Debug.Log(long.MaxValue);

        Debug.Log(sbyteValue);
        Debug.Log(shortValue);
        Debug.Log(intValue);
        Debug.Log(longValue);

        //필요한 값의 범위보다 무조건 큰 자료형을 쓰면?
        // -> 무의미하게 버려지는 데이터 공간이 많아진다. -> 메모리 공간 낭비

        // 필요한 값의 범위보다 무조건 작은 자료형을 쓰면?
        // -> 오버플로우 or 언더플로우가 발생한다 -> 버그

        int number = int.MinValue;
        number = number + 1; // 오버 플로우

        //int number = int.MinValue;
        number = number -1; // 언더 플로우

        Debug.Log(number);


        // 1-2 부호없는 정수형:
        // 부호가 없다-> + ,- 가 없다. (무조건 양수)
        byte bValue = 5;
        ushort ushortValue = 5;
        uint uintValue = 5;
        ulong ulongValue = 5;

        Debug.Log(bValue);
        Debug.Log(ushortValue);
        Debug.Log(uintValue);
        Debug.Log(ulongValue);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
