using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleTest : MonoBehaviour
{
    void Start()
    {
        People people = new People("�̼���", 25, 180.1f, "INFP");
        people.SetAge(26);
        people.SetAge(-3);

        people.Height = -10;        // set ������ ���
        Debug.Log(people.Height);   // get ������ ���


        people.MBTI = "AAA"; // �ǽ�. MBTI�� ���ؼ� ������Ƽ�� �����غ�����.
        Debug.Log(people.MBTI);
        // people.Age = -3;  // ���Ἲ�� ������!
        // ���Ἲ�̶� �������� ��Ȯ��, �ϰ���, ��ȿ��

        Debug.Log(people.GetName());
        Debug.Log(people.GetAge());
    }

}
