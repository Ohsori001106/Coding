using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test34 : MonoBehaviour
{
    public char C;
    void Start()
    {
        
        int asciiValue = (int)C; // 아스키 코드 값으로 변환
        

        Debug.Log(asciiValue); // 결과 출력

        Debug.Log(100 + 'a');
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
