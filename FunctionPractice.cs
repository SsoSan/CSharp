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

        Hi("�ȳ�");
    }

    int Add(int x, int y)
    {
        return x + y;
    }

    // ȭ��ǥ �Լ�, ���ٽ�, ����� �Լ�
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
��Ģ������ ���ϴ� �Լ� �����
+, -, *, /, %
�ΰ��� ������ �Է¹޾� +, -, *, /, % ����Ͽ�
������� ��ȯ�ϴ� �Լ� �����
Add, Subtract, Multiply, Devide, Remainder

�Է°� : 5, 3
[output]

*/