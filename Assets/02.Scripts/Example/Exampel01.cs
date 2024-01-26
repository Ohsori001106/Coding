using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 네임스페이스
// using으로 시작하는 위 문장 3개
// 이 스크립트 파일에서 필요한 외부 기능을 가져다 쓴다는 의미

// 하나의 스크립트 파일은 하나의'클래스'와 대응된다.
// 스크립트 파일을 만들면 자동으로 파일명과 같은 클래스가 만들어진다.
// 이스크립트 파일에서 구현하고자 하는 내용은 이 클래스 안에서 구현하게된다.

public class Exampel01 : MonoBehaviour // 스크립트 파일을 컨포넌트로 만들어준다.
{

    // Start와 Update는 함수다.
    // 함수란 유니티에서 일정 시점에 실행되는 코드다.

    // 게임이 시작할 때 (요기 있는 코드가) 한 번 실행된다.
    void Start()
    {
        // 요기 있는 코드
        Debug.Log("Hello C#!");

        // ;(세미콜론):문장(명령)의 끝을 의미한다.
    }

    // 게임이 시작하고 나서 매 프레임마다 실행된다.
    void Update()
    {
        Debug.Log("업데이트");
    }
}
