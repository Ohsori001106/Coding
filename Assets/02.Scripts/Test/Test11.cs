using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test11 : MonoBehaviour
{
    public int H;
    public int M;
    // Start is called before the first frame update
    void Start()
    {
        int h = H;
        int m= M-45;
            
         if (m < 0)
         {
               if (h > 0)
               {
                Debug.Log($"{h - 1}:{m + 60}");
               }
                if (h == 0)
            {
                h = 23;
                Debug.Log($"{h}:{m + 60}");
            }
              
         }
          else
          {
              Debug.Log($"{h}: {m}");
          }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
