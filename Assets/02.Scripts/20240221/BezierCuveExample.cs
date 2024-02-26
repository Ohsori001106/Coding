using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 베지어 곡선: 여러 점들 사이를 부드럽게 연결해주는 곡선
// Lerp는 두 점 사이의 직선 경로를 따라 간단한 보간 제공하는 반면,
// Bezier는 여러 점 사이의 복잡한 곡선 경로를 생성할 수 있다.

public class BezierCuveExample : MonoBehaviour
{
    public AnimationCurve Curve;

    public Transform Start;
    public Transform Center;
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

        
        transform.position = BezierLerp(Start.position,Center.position, End.position,_progress);
    }

    private Vector3 BezierLerp(Vector3 start, Vector3 center, Vector3 end, float progress)
    {
        // 1. 시작점과 중간점 사이의 보간 위치를 구한다.
        Vector3 m0 = Vector3.Lerp(start, center, progress);
        // 2. 중간점과 끝점 사이의 보간 위치를 구한다.
        Vector3 m1 = Vector3.Lerp(center, end, progress);
        // 3. m0과 m1 사이의 보간 위치를 구한다.
        Vector3 finalPoint = Vector3.Lerp(m0, m1, progress);

        return finalPoint;
    }
}
