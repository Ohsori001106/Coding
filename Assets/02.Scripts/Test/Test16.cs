using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test16 : MonoBehaviour
{
    public int A;
    // Start is called before the first frame update
    void Start()
    {
        int B = 1;
        

        for(int i = 1; i <= A; i++)
        {
            B *= i;
            


        }
        Debug.Log(B);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
