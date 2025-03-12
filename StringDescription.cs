using UnityEngine;

// String 클래스, StringBuilder 클래스를 이용하여 문자열 다루기
public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 문자열 관련 메서드 - 대문자, 소문자 바꿔버리기
        string message = "hello World!";

        Debug.Log(message);

        // [1] 대문자
        Debug.Log(message.ToUpper());

        // [2] 소문자
        Debug.Log(message.ToLower());

        // [3] 바꿔버리기
        Debug.Log(message.Replace("hello","안냐루").Replace("World", "야발"));
    }
}
