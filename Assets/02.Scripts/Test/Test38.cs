using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test38 : MonoBehaviour
{
    public string InputString;

    void Start()
    {
        char[] alphabets = new char[26];   //알파벳 배열 선언
        int[] firstint = new int[26];      // 답으로 쓸 배열

        for (int i = 0; i < 26; i++)       // 알파벳 배열 생성
        {
            alphabets[i] = (char)('a' + i);
        }

        char[] inputChars = InputString.ToCharArray();   //InputString을 char 배열로 변환

        for (int i = 0; i < 26; i++)     //답으로 쓸 배열의 모든 값을 -1로 선언
        {
            firstint[i] = -1; 
        }

        for (int i = 0; i < inputChars.Length; i++)    // 차 배열의 크기만큼 반복
        {
            int index = inputChars[i] - 'a';          // index 선언 index는 차배열의 i번째 에서 알파벳'a'(아스키 코드 97)를 뺀 숫자

            if (firstint[index] == -1)                //만약 int배열에 index 값이 -1 (위에서 전부 -1로 선언했었음)
            {
                firstint[index] = i;                  // firstint 는 = i(알파벳 배열의 위치)
            }
        }

        for (int i = 0; i < 26; i++)                // 전부 출력 입력된 int 배열 firstint[] 가 알파벳과 배열과 곂치지 않는 알파벳은 -1로 출력 곂치는 알파뱃은 
        {
            Debug.Log(firstint[i]);                 // int 배열 firstint[] 와 곂치는 알파벳이 있는 순서에 따라 인덱스값 출력
        }


        for (char i = 'a'; i <= 'z'; i++)
        {
            int B = InputString.IndexOf(i);
            Debug.Log(B);
        }

    }
}
