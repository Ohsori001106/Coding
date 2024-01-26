using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test41 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char[][] inputArray = new char[][]
{
    new char[] { 'A', 'A', 'B', 'C', 'D', 'D' },
  new char[] { 'a', 'f', 'z', 'z' },
  new char[] { '0', '9', '1', '2', '1' },
  new char[] { 'a', '8', 'E', 'W', 'g', '6' },
  new char[] { 'P', '5', 'h', '3', 'k', 'x' }
};
        string a = "";
        int maxLength=0;
        for(int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length > maxLength)
            {
                maxLength = inputArray[i].Length;
            }
        }
        

        for (int i = 0; i < maxLength; i++)
        {
            for (int j = 0; j < inputArray.Length; j++)
            {
                if (i < inputArray[j].Length)
                {
                    a += inputArray[j][i];
                }
            }
        }

        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
