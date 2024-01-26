using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test08 : MonoBehaviour
{
    public int Grades;
    int maxValue = 100;
    // Start is called before the first frame update
    void Start()
    {
        if (Grades <=100 && Grades >= 90)
        {
            Debug.Log("A");
        }
        else if (Grades >= 80)
        {
            Debug.Log("B");
        }

        else if(Grades >= 70)
        {
            Debug.Log("C");
        }

        else if(Grades >= 60)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }

        switch (Grades)
        {
            case >= 90:
                {
                    Debug.Log("A");
                    break;
                }
            case >= 80:
                {
                    Debug.Log("B");
                    break;
                }
            case >= 70:
                {
                    Debug.Log("C");
                    break;
                }
            case >= 60:
                {
                    Debug.Log("D");
                    break;
                }
                
            default:
                {
                    Debug.Log("F");
                    break;
                }

        }
        Grades /= 10;
        switch(Grades)
        {
            case 10:
            case 9:
                {
                    Debug.Log("A");
                    break;
                }
            case 8:
                {
                    Debug.Log("B");
                    break;
                }
            case 7:
                {
                    Debug.Log("C");
                    break;
                }
            case 6:
                {
                    Debug.Log("D");
                    break;
                }
            default:
                {
                    Debug.Log("F");
                    break;
                }
        }










    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
