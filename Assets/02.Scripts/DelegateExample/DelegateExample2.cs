using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class DelegateExample2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numvers = { -10, 20, -30, 4, -5 };

        // 사용 예시1.
        // 대리자를 통해 메서드를 매개변수로 전달할 수 있다.

        // C#의 배열이나 컬렉션에는 데이터를 쉽게 가공할 수 있는 Linq 기능이 있다.
        // Linq: 데이터들에게 질문을 던지고 그 결과를 받아오는 기능
        int count = numvers.Count(IsBiggerThenZero);
        Debug.Log(count);

        /*int count = 0;
        for (int i = 0; i < numvers.Length; i++)
        {
            if (numvers[i] > 0)
            { 
                count++;
            }
        }

        Debug.Log(count);*/
    }
    private bool IsBiggerThenZero(int num)
    {
        return num > 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
