using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test20 : MonoBehaviour
{
    public int N;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 1; i <= N; i++)
        {
            string star = "";
            string space = "";

            for (int j = 0; j < N-i; j++)
            {
                space += "  ";
            }

            for (int j = 0; j < i; j++)
            {
                star += "*";
            }
            Debug.Log($"{space}{star}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
