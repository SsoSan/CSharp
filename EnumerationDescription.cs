using UnityEngine;

// [1] 우선순위를 관리하는 열거형 생성(선언, 만들기)
// 사용자 정의 데이터 형식
enum Priorty
{
    High,
    Normal,
    Low,
}

public class EnumerationDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 열거형 변수 선언 및 초기화
        // 열거형 변수에 저장되는 값은 정의에서 만들어진 상수 값만 가능
        Priorty high = Priorty.High;
        Priorty normal = Priorty.Normal;
        Priorty low = Priorty.Low;

        Debug.Log($"{high}, {normal}, {low}");
    }
}

/*
Enumeration(열거형) : 하나의 이름으로 서로 관련있는 정수 값을 가지는 상수들의 집합

// 형식
enum (enum 이름)
{
    상수명,
    상수명,
    상수명,
    ...
}
*/