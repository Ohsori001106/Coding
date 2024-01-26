using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test10 : MonoBehaviour
{
    public int X;
    public int Y;
    // Start is called before the first frame update
    void Start()
    {
        if (X > 0)
        {
            if(Y > 0)
            {
                Debug.Log($"1");
            }
            else
            {
                Debug.Log($"4");
            }

        }
        else
        {
            if( Y > 0)
            {
                Debug.Log($"2");
            }
            else
            {
                Debug.Log($"3");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
