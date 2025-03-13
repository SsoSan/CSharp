using UnityEngine;

public class TryCatchFinallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 5;
        int y = 0;
        int r = 0;

        try     // 예외가 발생 할 가능성이 있는 구문
        {
            // [1]
            r = x / y;
            Debug.Log($"{x} / {y} = {r}");
        }
        catch   // try 구문 에서 예외가 발생하면 catch 구문 안의 명령문을 실행
        {
            // [2]
            Debug.Log("예외 발생했농");
        }
        finally // try 구문에서 예외(오류) 발생 유무와 상관없이 실행
        {
            // [3]
            Debug.Log("프로그램 끔");
        }

        // try 구문에서 예외가 발생하면 : [1] => [2] => [3]
        // try 구문에서 예외가 발생하지 않으면 : [1] => [3]
    }
}
