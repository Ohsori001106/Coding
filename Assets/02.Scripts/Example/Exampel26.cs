using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exampel26 : MonoBehaviour
{

    void Start()
    {
        string fristName = "전";
        string lastName = "민성";
        string displatName = string.Empty;

        // 1. 더하기 (+) 연산자 사용
        displatName = "이름: " + fristName + lastName;
        Debug.Log(displatName);

        // 2. string.Format 사용
        displatName = string.Format("이름: {0},{1}", fristName + lastName);
        Debug.Log(displatName);

        // 3. 문자열 보간법($) 사용
        displatName = $"이름 {fristName}{lastName}";
        Debug.Log(displatName);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
