using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test26 : MonoBehaviour
{
    public int[] A;
    // Start is called before the first frame update
    void Start()
    {
        float sun = 0;
        float moon = 0;
        for (int i = 0; i < A.Length; i++)
        {
            sun += A[i];
            moon += 1;
        }
       
        Debug.Log(sun / moon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
