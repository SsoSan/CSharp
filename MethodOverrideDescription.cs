using UnityEngine;

namespace Override
{
    public class MethodOverrideDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            /*
            // Child 클래스의 인스턴스 생성
            Child child = new Child();
            child.Say();
            child.Run();
            child.Walk();
            */

            // Overloading
            int iNumber = 100;
            double dNumber = 3.14;

            PrintNumber(iNumber);
            PrintNumber(dNumber);
            PrintNumber(3, 5);
        }

        // Method Overload, Overloading
        void PrintNumber(int number) => Debug.Log($"{number}");
        void PrintNumber(double number) => Debug.Log($"{number}");
        void PrintNumber(int a, int b) => Debug.Log($"{a + b}");
    }
}

/*
Method Override(메서드 재 정의, 메서드 오버라이드)
 - 엄빠클래스의 메서드를 재 정의(다시 정의)해서 사용
 - 상속의 개념에서 나옴

Method Overload, Overloading(다중 정의, 여러변 정의)
 - 한 클래스 코드블록 안에서 구현
 - 함수 이름은 길고 매개변수가 다르게 여러번 정의해서 사용
*/