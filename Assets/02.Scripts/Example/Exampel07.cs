using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exampel07 : MonoBehaviour
{
    // ������
    // ���(����) ����������: ��� ������ ������ �����ϱ� ���� ����ϴ� Ű����
    // private: Ŭ���� ���ο����� ���� �����ϴ�.(default)
    // public: �ܺο��� �����Ӱ� ������ �����ϴ�.

    public int age = 24;
    public string name = "Ƽ��";
    public float height = 148.6f;



    void Start()
    {
        Debug.Log("�ȳ��ϼ���. C#�Դϴ�.");
        Debug.Log("�̸�:"+name);
        Debug.Log("����:"+age);
        Debug.Log("Ű:"+height);
        
    }

    void Update()
    {
        
    }
}
