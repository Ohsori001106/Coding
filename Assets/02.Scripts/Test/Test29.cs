using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test29 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

        int length = array.Length; // int length = 9

        for (int i = 0; i < length / 2; i++) // i가 0일때 i가 9/2 보다 작을때(4) 까지 i에 1을 더한다
        {
            int back = array[i];                // int back = 배열array [1,2,3]
            array[i] = array[length - i - 1];   // array [ 1, 2, 3] = array[ length(9) - [1, 2, 3] -1 )
            array[length -i - 1] = back;        // array[ length(9) - [1, 2, 3] -1 ) = back 다
        }

        for (int i = 0;i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
