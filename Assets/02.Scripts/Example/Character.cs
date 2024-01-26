using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Character : MonoBehaviour
{

    // 변수 이름은 의미있게
    // 표기법: "파스칼케이스"

    [Header("이름")]
    public string Name = "시즈땡크";

    [Header("직업")]
    public string Job = "메카닉";

    [Header("길드")]
    public string Guild = "순애";

    [Header("종족")]
    public string Species = "인간";

    [Header("성별")]
    public string Gender = "여성";

    [Header("나이")]
    public int Age = 20;

    [Header("인기도")]
    public int Popularity = 513;

    [Header("HP")]
    public int HealthPoint = 74884;

    [Header("MP")]
    public int ManaPower = 37332;

    [Header("STR")]
    public int Strength = 8725;

    [Header("DEX")]
    public int Dexterity = 80570;

    [Header("INT")]
    public int Intelligence = 5838;

    [Header("LUK")]
    public int Luck = 6117;

    [Header("크리티컬 확률")]
    public int CriticalProbability = 100;

    [Header("공격력")]
    public int Power = 100;



    [Header("데미지")]
    public float Damage = 107.00f;

    [Header("최종 데미지")]
    public float FinalDamage = 52.90f;

    [Header("방어율 무시")]
    public float DisregardForDefense = 95.64f;

    [Header("크리티컬 데미지")]
    public float CriticalDamage = 82.55f;

    [Header("보스 데미지")]
    public float BossDamage = 379.00f;











    void Start()
    {

        Debug.Log("이름:" + Name);
        Debug.Log("나이:" + Age);
        Debug.Log("직업:" + Job);
        Debug.Log("길드:" + Guild);
        Debug.Log("종족:" + Species);
        Debug.Log("성별:" + Gender);
        Debug.Log("인기도:" + Popularity);
        Debug.Log("HP:" + HealthPoint);
        Debug.Log("MP:" + ManaPower);
        Debug.Log("STR:" + Strength);
        Debug.Log("DEX:" + Dexterity);
        Debug.Log("INT:" + Intelligence);
        Debug.Log("LUK:" + Luck);
        Debug.Log("데미지:" + Damage);
        Debug.Log("보스 데미지:" + BossDamage);
        Debug.Log("최종 데미지:" + FinalDamage);
        Debug.Log("방어율 무시:" + DisregardForDefense);
        Debug.Log("크리티컬 확률:" + CriticalProbability);
        Debug.Log("크리티컬 데미지:" + CriticalDamage);
        Debug.Log("공격력:" + Power);


    }

    void Update()
    {
        
    }
}
