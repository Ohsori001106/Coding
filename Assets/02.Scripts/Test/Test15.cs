using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test15 : MonoBehaviour
{
    public int N;

    // Start is called before the first frame update
    void Start()
    {
        
        int sum = 0;
        
        for (int i = 1; i <= N; i++)
        {
            
            if (i % 3 != 0)
            {
               sum += i;
            }
        }

        Debug.Log(sum);
            

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
