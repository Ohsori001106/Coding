using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exampel07 : MonoBehaviour
{
    // 프로필
    // 멤버(변수) 접근제한자: 멤버 변수의 접근을 제한하기 위해 사용하는 키워드
    // private: 클래스 내부에서만 접근 가능하다.(default)
    // public: 외부에서 자유롭게 접근이 가능하다.

    public int age = 24;
    public string name = "티모";
    public float height = 148.6f;



    void Start()
    {
        Debug.Log("안녕하세요. C#입니다.");
        Debug.Log("이름:"+name);
        Debug.Log("나이:"+age);
        Debug.Log("키:"+height);
        
    }

    void Update()
    {
        
    }
}
