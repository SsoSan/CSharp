using UnityEngine;

// 열거형 값을 정수형이나 문자열로 사용 가능
enum Animals
{
    Rabbit,
    Dragon,
    Snake,
}

public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 열거형 변수 선언, 초기화
        Animals animal = Animals.Dragon;
        int num = (int)animal;
        string str = animal.ToString();

        Debug.Log($"Animals.Dragon : {num}, {str}");
    }
}
