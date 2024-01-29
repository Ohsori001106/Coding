using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericExmaple : MonoBehaviour
{
    
    void Start()
    {
        
        Person<int,float> p1 = new Person<int,float>();
        p1.Name = "엄마";
        p1.Age = 34;

        Person<int,int> p2 = new Person<int,int>();
        p2.Name = "아빠";
        p2.Age = 33;

        // 갑자기 사람 데이터의 요구사항이 Age가 int가 아닌 float 값을 담아야 하는 요구사항
        Person<float,float> p3 = new Person<float, float>();
        p3.Name = "아들";
        p3.Age = 0.8f;



    }

    // 제네릭(Generic: 일반화)은 타입(자료형)을 미리 설정하지 않고, 사용할 때 무엇인지 정의하는것
    // 제네릭이란 "타입에 상관없는~"

    // T: Type Parameter의 약자
    public class Person<T1,T2>  // 2. 그리고 클래스 이름 옆에 <T> 추가해줌으로써
    {                       //    객체를 생성할 때 이 타입(T)을 정의하게 한다.
        public string Name;
        public T1 Age;        // 1. 먼저 Age 속성의 타입을 미리 정하지 않고 T라고 한다.
        public T2 Weight;

        public T1 GetAge()
        {
            return Age;
        }
        public void SetAge(T1 value)
        {
            Age = value;
        }

    }


}
