using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LarpExample : MonoBehaviour
{

    // 보간 : 시작과 끝점이 주어졌을 때 두 점 사이의 진행률(비율)에 따라 그 사이의 특정한 지점을 얻는 것
    // 진행률(비율)-> 0~1 사이의 값
    // 무언가를 부드럽게 할 때 사용

    // 선형 보간(Lerp: Linear Interpolation)-> 직선
    // "직선" : 균일한 속도로 이동시키거나 화전시킬 때 사용
    public Transform Start;
    public Transform End;

    private float _progress;

    public float Duration = 3f;

    public bool rihgt = false;

    // Update is called once per frame
    void Update()
    {
        if ( rihgt)
        {
            _progress += Time.deltaTime / Duration;
        }
        else
        {
            _progress -= Time.deltaTime / Duration;
        }

       

        


        if (_progress > 1)
        {
            

            _progress = 1;

            rihgt = false;
        }

        if (_progress < 0)
        {

            _progress = 0;
            

            rihgt = true;
        }
        transform.position = Vector3.Lerp(Start.position, End.position, _progress);
    }
}