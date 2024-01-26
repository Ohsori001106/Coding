using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextFileStreamExample : MonoBehaviour
{
    // 파일 스트림
    // 파일을 다룰 때 데이터가 움직이는 것을 흐름(stream)으로 비유한 것
    // 파일을 다루기 위해서는 Ststem.io 네임스페이스에 있는 FileStream 클래스 사용
    void Start()
    {
        // 1. <파일열기>
        

        // 매개변수
        // 1. 어떤 파일? (파일의 경로)
        // 2. 어떻게 다룰꺼냐? (파일의 모드)
        // 타입 변수명 = 
        FileStream fs =new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        // FileMode.Create: 파일이 없다면 새로 생성해주고, 있으면 덮어씌운다.

        // <텍스트 쓰기>
        // 텍스트 파일을 쓸때 는 "StreamWriter" 클래스 사용
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("hello");
        sw.WriteLine("제 이름은 이성민입니다.");
        sw.WriteLine("방가방가");
        sw.Close(); // 파일을 다쓰면 꼭 닫아줘야 한다.

        // <파일 읽기>
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open); // 다시 열기
        StreamReader sr = new StreamReader(fs);
        while (true)
        {
            string line = sr.ReadLine();
            
            if (line ==null)
            {
                break;
            }
            Debug.Log(line);
        }
        sr.Close();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
