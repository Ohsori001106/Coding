using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test40 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 입력 코드
        char[][] inputArray = new char[][]
        {
      new char[] { 'A', 'B', 'C', 'D', 'E' },
      new char[] { 'a', 'b', 'c', 'd', 'e' },
      new char[] { '0', '1', '2', '3', '4' },
      new char[] { 'F', 'G', 'H', 'I', 'J' },
      new char[] { 'f', 'g', 'h', 'i', 'j' }
        };
        string array = "";
        
        for (int i = 0; i < inputArray.Length; i++)
        {
            array += new string(inputArray[i]);
        }

        
        
        Debug.Log(array);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
