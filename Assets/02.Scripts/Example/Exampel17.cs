using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exampel17 : MonoBehaviour
{
    public string Id;
    public string Password;

    const string ID = "teemo";
    const string PASSWORD = "1234";

        // Start is called before the first frame update
    void Start()
    {
        // 1. ID가 다르면 출력: "존재하지 않는 ID입니다."
        // 2. ID가 같으나 비밀번호가 다르면 출력: "비밀번호가 틀렸습니다."
        // 3. ID와 비밀번호가 모두 같으면 출력: "로그인 됐습니다."

       
        if (Id != ID)
        {
            Debug.Log("존재하지 않는 ID입니다.");
        }

        else if (Password != PASSWORD) 
        {
            Debug.Log("비밀번호가 틀렸습니다.");
        }

  //      if (Id == ID && PASSWORD == Password)
        else 
        {
            Debug.Log("로그인 됐습니다.");
        }

        // 중첩 조건문: 조건문 안에 도 다른 조건문이 들어가 있는 형태
        // 3중 조건문이 되면 '나밖에 이해못함' 다시 생각해보자.
  /**     else 
        {
            if (Password != PASSWORD)
            {
                Debug.Log("비밀번호가 틀렸습니다");
            }

            if (Password == PASSWORD)
            {
                Debug.Log("로그인 됐습니다.");
            }
        } **/


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
