using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 보간 : 시작과 끝점이 주어졌을 때 두 점 사이의 진행률(비율)에 따라 그 사이의 특정한 지점을 얻는 것
// 진행률(비율)-> 0~1 사이의 값
// 무언가를 "부드럽게" 할 때 사용

// Curve(곡선): 연속적인 점의 집합
public class CurveExample : MonoBehaviour
{
    // 보간을 시각적으로 볼 수 있는 그래프 에디터
    public AnimationCurve Curve;
    
    public Transform Start;
    public Transform End;

    private float _progress;

    public float Duration = 3f;
    public bool rihgt = false;

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
        
    
    transform.position = Vector3.Slerp(Start.position, End.position,Curve.Evaluate(_progress));
    }

}
