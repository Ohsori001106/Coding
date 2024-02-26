using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CoroutineExample2 : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(Timer_Coroutine(3));
    }

    private IEnumerator Timer_Coroutine(float delayTime)
    {
        int count = 10;

        // 주어진 시간만큼 대기
        while (true)
        {
            yield return new WaitForSeconds(delayTime);

            Debug.Log("띵띵땅땅땅");

            count--;

            yield return new WaitForSeconds(delayTime);

            Debug.Log("띵띵땅땅땅2");

            count--;

            if (count <= 0)
            {
                yield break;
            }
        }
        
    }
    
}
