using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test31 : MonoBehaviour
{
    public string String;
    public int Number;
    void Start()
    {
        char word = String[Number];

        Debug.Log(char.ToUpper(word));

        if (char.IsUpper(word))
        {
            Debug.Log(word);
        }
        else
        {
            Debug.Log(char.ToUpper(word));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
