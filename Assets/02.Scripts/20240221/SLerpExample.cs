using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLerpExample : MonoBehaviour
{
    // 보간 : 시작과 끝점이 주어졌을 때 두 점 사이의 진행률(비율)에 따라 그 사이의 특정한 지점을 얻는 것
    // 진행률(비율)-> 0~1 사이의 값
    // 무언가를 부드럽게 할 때 사용

    // 구면선형보간(Slerp: Sphercial Linear Interpolation)-> 
    // 직선 형태가 아닌 "구면" 형태로 값을 추론한다.
    // 시작점과 종료점은 느리게 증가하고, 중간지점은 빠르게 이동하는 특성
    // -> 자연스러운 회전 로직에 많이 사용한다.

    public Transform Start;
    public Transform End;

    private float _progress;

    public float Duration = 3f;

    public bool rihgt=false;
    
    void Update()
    {
        if (rihgt)
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
