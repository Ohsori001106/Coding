using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public string Name;
    public int Age;
    public string Color;
    public string Species;
    public float Weigh;
    public bool LikeWater;

    public Cat()
    {

    }
    public Cat(string name, int age, string color, string species, float weigh, bool likewater)
    {
        Name = name;
        Age = age;
        Color = color;
        Species = species;
        Weigh = weigh;
        LikeWater = likewater;
    }

    public void Speak()
    {
        Debug.Log($"우리 고양이의 이름은 {Name}이고, 나이는 {Age}살이야 색깔은 {Color}이고 종은 {Species}야 몸무게는 {Weigh}고 물을 좋아하냐면{LikeWater}야");
    }
    public void Run()
    {
        Debug.Log($"{Name}가 뛰어다닌다");
    }
    public void Sleep()
    {
        Debug.Log($"{Name}가 잠들었다");
    }
    public void Howl()
    {
        Debug.Log($"{Name}가 야옹 하고 울었다");
    }
    public void Grooming(Cat OtherCat)
    {
        Debug.Log($"{Name}가 {OtherCat.Name}를 햟고 있다");
    }
    public void Grooming(Dog OtherDog)
    {
        Debug.Log($"{Name}가 {OtherDog.Name}를 햟고 있다");
    }


}
