using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Test05 : MonoBehaviour
{
    public float M;
    public int kg;


    void Start()
    {
        float M = 180;
            float kg = 73;

        float h = M / 100;

        

        // bmi=(kg/(h*h));
        Debug.Log(string.Format("BMI: {0:F}", (kg / (h * h))));
        Debug.Log( $"BMI: {kg / (h * h):F}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
