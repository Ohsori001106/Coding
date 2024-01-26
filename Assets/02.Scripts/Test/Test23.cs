using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test23 : MonoBehaviour
{
    public int[] N;
    public int v;
    // Start is called before the first frame update
    void Start()
    {
        
        int conut = 0;

        for (int i = 0; i < N.Length; i++)
        {
          if (N[i] == v)
            {
                conut += 1;
            }
            
        }
        Debug.Log(conut);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
