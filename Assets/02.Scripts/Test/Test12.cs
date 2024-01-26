using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test12 : MonoBehaviour
{
    public int Hour;
    public int Min;
    public int AddMin;
    // Start is called before the first frame update
    void Start()
    {
        int newHour = Hour;
        int newMin = Min + AddMin;

        if (newMin >= 60)
        {
            newHour += (newMin / 60); //시간은 더해주고
            newMin = (newMin % 60); //분은 나머지.
        }

        if (newHour >= 24)
        {
            newHour -= 24;
        }
        Debug.Log($"{newHour}:{newMin}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
