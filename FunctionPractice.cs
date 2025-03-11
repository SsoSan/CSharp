using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result;

        result = Add(5, 3);
        Debug.Log(result);

        result = Subtract(5, 3);
        Debug.Log(result);

        result = Multiply(5, 3);
        Debug.Log(result);

        result = Devide(5, 3);
        Debug.Log(result);

        result = Remainder(5, 3);
        Debug.Log(result);

        Hi("안넝");
    }

    int Add(int x, int y)
    {
        return x + y;
    }

    // 화살표 함수, 람다식, 축약형 함수
    int Subtract(int x, int y) // => x - y;
    {
        return x - y;
    }

    int Multiply(int x, int y) // => x * y;
    {
        return x * y;
    }

    int Devide(int x, int y) // => x / y;
    {
        return x / y;
    }

    int Remainder(int x, int y) // => x % y;
    {
        return x % y;
    }

    void Hi(string msg) => Debug.Log(msg);
}

/*
[Q]
사칙연산을 구하는 함수 만들기
+, -, *, /, %
두개의 정수를 입력받아 +, -, *, /, % 계산하여
결과값을 반환하는 함수 만들기
Add, Subtract, Multiply, Devide, Remainder

입력값 : 5, 3
[output]

*/