using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class Test37 : MonoBehaviour
{
    public string S;
    // Start is called before the first frame update
    void Start()
    {
        char[] chars = S.ToCharArray();

        for (int i = 0; i < chars.Length / 2; i++)
        {
            char back = chars[i];
            chars[i] = chars[chars.Length - i -1];
            chars[chars.Length - i -1] = back;
             
        }
        
            Debug.Log(new string(chars));

        /*string s = "";
        
        for (int i = chars.Length -1;i >= 0;i--)
        {
             s += chars[i];
        }
        Debug.Log(s);*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
