using UnityEngine;

// MethodOverload(메서드 오버로드, 함수 다중정의)
// 동일한 이름의 메서드로 매개변수를 달리해서 여러개 생성
public class MethodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintNumber(1234);
        PrintNumber(1234L);
        PrintNumber(1234F);
    }

    // 매개변수로 숫자를 입력받아 출력하는 함수 : PrintNumber
    // int 타입의 정수를 매개변수로 입력받아 출력
    void PrintNumber(int number)
    {
        Debug.Log($"Int32 : {number}");
    }

    // long 타입의 정수를 매개변수로 입력받아 출력
    void PrintNumber(long number)
    {
        Debug.Log($"int64 : {number}");
    }

    // float 타입의 정수를 매개변수로 입력받아 출력
    void PrintNumber(float number)
    {
        Debug.Log($"실수형 : {number}");
    }
}
