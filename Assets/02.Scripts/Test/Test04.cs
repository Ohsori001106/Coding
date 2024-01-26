using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 472;
        int b = 385;



        Debug.Log(a * (b % 10));
        Debug.Log(a * ((b/10)%10));
        Debug.Log(a *(b/100));
        Debug.Log(a *b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
