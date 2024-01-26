using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int a = 5;
        int b = 8;
        int c = 4;


        Debug.Log((a + b) % c);
        Debug.Log((a % c) + (b % c));
        Debug.Log((a *b)%c);
        Debug.Log((a %c)*(b%c)%c);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
