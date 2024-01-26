using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test06 : MonoBehaviour
{
    public int A;
    public int B;
    // Start is called before the first frame update
    void Start()
    {
        if (A > B)
        {
            Debug.Log(">");
        }

        else
        {
            if(A < B)
            {
                Debug.Log("<");
            }
            else
            {
                Debug.Log("==");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
