using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BinaryFileStreamExample : MonoBehaviour
{
    void Start()
    {
        // <���� ����>
        // �Ű�����
        // 1. � ����? (������ ���)
        // 2. ��� �ٷ겨��? (������ ���)
        // Ÿ�� ������ = 
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        // FileMode.Create: ������ ���ٸ� ���� �������ְ�, ������ ������.
        // .dat: ������(data)�� ���� ����ڰ� ������ �����Ͱ� ����ִ� ������ Ȯ����

        // <���� ����>
        // ���̳ʸ� ������ ������ "BinartWriter" Ŭ���� ���
        BinaryWriter bw = new BinaryWriter(fs);
        bw.Write("Hello");
        bw.Write(593);
        bw.Close();

        // ����: ��ǻ�ʹ� �����͸� 0��1 ���� ���̳ʸ� ���·� ó���ϹǷ�
        // BinaryWrite�� ����ϸ� �޸𸮸� �� �� ȿ�������� ����ϰ�, �ӵ��� �� ������.

        // <���� �б�>
        // ���̳ʸ� ������ ���� ���� "BinaryReader" Ŭ���� ���
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open);
        BinaryReader br = new BinaryReader(fs);
        Debug.Log(br.ReadString());
        Debug.Log(br.ReadInt32());
        br.Close();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
