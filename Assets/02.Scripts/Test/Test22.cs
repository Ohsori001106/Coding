using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test22 : MonoBehaviour
{
    public int N;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= N; i++)
        {
            string Star = "";
            for (int j = 1; j <= i; j++)
            {
                Star += "*";

            }
            Debug.Log(Star);
        }
        for (int i = 1; i < N; i++)
        {
            string Star = "";
            for (int j = 0; j < N-i; j++)
            {
                Star += "*";

            }
            Debug.Log(Star);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
