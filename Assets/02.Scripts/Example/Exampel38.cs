using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exampel38 : MonoBehaviour
{
    // 가변 길이 매개 변수
    // -> 매개 변수 개수가 유연하게 변한다.
    int Add(params int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        return sum;
        void Start()
        {
            Debug.Log(Add(1, 2, 3, 4, 5));
            Debug.Log(Add(1, 2, 3, 4));
            Debug.Log(Add(1, 2, 3));
            Debug.Log(Add(1, 2));
            Debug.Log(Add(1));

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
