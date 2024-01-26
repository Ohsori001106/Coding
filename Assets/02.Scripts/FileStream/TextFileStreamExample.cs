using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextFileStreamExample : MonoBehaviour
{
    // ���� ��Ʈ��
    // ������ �ٷ� �� �����Ͱ� �����̴� ���� �帧(stream)���� ������ ��
    // ������ �ٷ�� ���ؼ��� Ststem.io ���ӽ����̽��� �ִ� FileStream Ŭ���� ���
    void Start()
    {
        // 1. <���Ͽ���>
        

        // �Ű�����
        // 1. � ����? (������ ���)
        // 2. ��� �ٷ겨��? (������ ���)
        // Ÿ�� ������ = 
        FileStream fs =new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        // FileMode.Create: ������ ���ٸ� ���� �������ְ�, ������ ������.

        // <�ؽ�Ʈ ����>
        // �ؽ�Ʈ ������ ���� �� "StreamWriter" Ŭ���� ���
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("hello");
        sw.WriteLine("�� �̸��� �̼����Դϴ�.");
        sw.WriteLine("�氡�氡");
        sw.Close(); // ������ �پ��� �� �ݾ���� �Ѵ�.

        // <���� �б�>
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open); // �ٽ� ����
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
