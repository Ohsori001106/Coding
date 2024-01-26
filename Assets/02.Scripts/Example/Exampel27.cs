using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exampel27 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 문자
        char a = 't';

        // 문자열: 문자 + 배열의 줄임말
        string b = "Hello";

        

        Debug.Log(b.Length); // 문자열도 배열처럼 길이를 알 수 있는 Length 속성이 있다.
        Debug.Log(b[0]);
        Debug.Log(b[1]);
        Debug.Log(b[2]);

        // b[0] = 'K';   // 문자열안의 문자 값을 수정할 수 없다. -> 불변의 성질을 가지고 있다.

        string c = "Hello";
        c = c + "K";   // 문자열을 묶는것은 사실 내부적으로는 새로 만든다.

        string d = "Hello";
        d= "K" + c[1] + d[2] + d[3] + d[4];

        Debug.Log(d);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
