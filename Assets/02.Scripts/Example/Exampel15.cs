using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exampel15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 데이터의 형 변환
        // -> 변수에 담겨 있는 데이터를 다른 데이터 타입(자료형)의 변수에 옮겨 담는 것

        // 1. 정수 사이의 변환(sbyte, short, int, long 등)

        sbyte sbyteValue = 10;             //short 범위: -128 ~ 127
        int intValue = (int)sbyteValue;    // int 범위: -21억 ~ 21억

        Debug.Log($"sbyteValue: {sbyteValue}");
        Debug.Log($"intvalue: {intValue}");

        // 1-1. 옮겨 담는 자료형이 더 작고, 값의 범위를 넘어섰을 때
        intValue = 130;
        sbyteValue = (sbyte)intValue;
        Debug.Log($"sbyteValue: {sbyteValue}");      // -126 (오버플로우 발생) 최대 출력범위를 한바퀴 넘어서 돌아옴
        Debug.Log($"intvalue: {intValue}");

        // 2. 실수 사이의 변환(float, double, decimal)
        // 실수는 오버플로우가 존재하지 않고, 정밀도에 손상을 입는다. 
        double doubleValue = 3.146515432154;
        float floatValue = (float)doubleValue;
        Debug.Log($"doubleValue: {doubleValue}");
        Debug.Log($"floatValue: {floatValue}");

        // 3. 실수를 정수로 형변환
        // 내림: 소수점 아래는 버리고 소수점 위의 값만 남긴다. (반올림 안함)
        // 0/1f -> 0
        // 0.9f -> 0
        // 1.1f -> 1
        // 3.1415123f -> 3
        float floatValue2 = 0.9f;
        int intValue2 = (int)floatValue2;
        Debug.Log($"intValue2: {intValue2}");  // 0

        // 4. 숫자를 문자로 형변환
        // Tostring() 메소드를 이용
        int intValue3 = 10;
        string stringValue3 = intValue3.ToString();
        Debug.Log($"stringValue3: {stringValue3}");

        // 5. 문자열을 숫자로 형변환
        // 5-1. Parse() 메소드를 이용
        string stringValue5 = "4354";
        int intValue5 = int.Parse(stringValue5);
        Debug.Log($"intValue5: {intValue5}");

        // 5-2. Tryparse() 메소드 이용하기
        // -> 형 변환 성공 여부를 논리형으로 알려준다.
        string stringValue6 = "4354";
        int intValue6;
            bool isSuccess = int.TryParse(stringValue6, out intValue6);
        Debug.Log($"변환결과: {isSuccess}");

        string stringValue7 = "1557sd";
        int intValue7;
        bool isSuccess2 = int.TryParse(stringValue7, out intValue7);

        if (isSuccess2)
        {
            Debug.Log($"숫자로 변환된 값: {intValue7}");
        }
        else
        {
            Debug.Log("숫자로 변환할 수 없습니다.");
        }


        int a = 7;
        int b = 6;
        int c = a + b;

        Debug.Log(c);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
