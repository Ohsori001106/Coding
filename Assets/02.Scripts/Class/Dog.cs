using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public string Name;
    public int Age;
    public string Color;
    public string Species;
    public float Weigh;
    public bool Walk;

    public Dog(string name, int age, string color, string species, float weigh, bool walk)
    {
        Name = name;
        Age = age;
        Color = color;
        Species = species;
        Weigh = weigh;
        Walk = walk;
    }
    public void Speak()
    { 
    Debug.Log($"우리 강아지의 이름은 {Name}이고, 나이는 {Age}살이야 색깔은 {Color}이고 종은 {Species}야 몸무게는 {Weigh}고 오늘 산책을 했냐면 {Walk}야");
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
        Debug.Log($"{Name}가 짖고 있다");
    }
    public void Take(Cat OtherCat)
    {
        Debug.Log($"{Name}가 {OtherCat.Name}를 물고 오고 있다");
    }
    public void Take(Dog OtherDog)
    {
        Debug.Log($"{Name}가 {OtherDog.Name}를 물고 오고 있다");
    }
}
