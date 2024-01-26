using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test33 : MonoBehaviour
{
    public string String;
    void Start()
    {
        

        string inputstring = String;
        char space = ' ';
        int sp = 0;
        for(int i = 0; i < inputstring.Length; i++)
        {
            if (inputstring[i] ==space)
            {
                 sp ++;

            }
            
        }
        


        Debug.Log(sp+1); 
 
          
           
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
