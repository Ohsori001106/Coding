using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test17 : MonoBehaviour
{
    public int N;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 1; i <= 9; i++)
        {
            
            Debug.Log(N*i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
