using UnityEngine;

public class FunctionFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 함수 호출 : 3번
        Hi();
        Hi();
        Hi();
    }

    // [1] 함수 만들기(선언, 정의)
    void Hi()
    {
        Debug.Log("안녕");
    }
}
