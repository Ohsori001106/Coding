using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test30 : MonoBehaviour
{
    public int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    
    // Start is called before the first frame update
    void Start()
    {
        
        bool[] checks = new bool[42];

        // 1. 배열 A의 모든 값을 확인하고 싶다.
        for (int i = 0; i < A.Length; i++)
        {
            // 2. 각 요소의 값을 42로 나눈 나머지 값 확인
            // Debug.Log(A[i]%42);
            checks[A[i]%42] = true;

        }

        // 서로 다른 나머지가 몇 개 있는지 출력한다.
        int count = 0;
        // 3. checks 배열에서 true 개수를 구한다.
        foreach (bool check in checks)
        {
            if (check == true)
            {
                count++;
            }
        }
        Debug.Log(count);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
