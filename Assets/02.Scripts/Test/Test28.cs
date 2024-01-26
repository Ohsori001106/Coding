using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Test28 : MonoBehaviour
{

    void Start()
    {
        // 주어진 28개 학생의 출석번호를 담은 배열 A
        int[] A = { 3, 1, 4, 5, 7, 9, 6, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        // 과제출석부, 30명의 전체 학생 목록 배열
        bool[] allStudents = new bool[30]; // 기본으로 30개가 다 false
      

        // 제출한 학생들을 전체 학생 목록에서 제거하여 누락된 학생들을 찾음
        for (int i = 0; i < A.Length; i++)
        {
            int num = A[i];       // 학생 번호 1 ~ 30
            int indexNum = num - 1;  //  0 ~ 29 

            allStudents[indexNum] = true; // 제출한 학생은 해당 인덱스를 0으로 변경
        }

        // 누락된 두 명의 학생 번호를 찾음
        for (int i = 0; i < allStudents.Length; i++)
        {
            if (allStudents[i] == false)
            {
                Debug.Log(i + 1);
            }

        }
     

    }
        // Update is called once per frame
        void Update()
        {

        }
    }
