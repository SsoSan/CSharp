using UnityEngine;

namespace Method
{
    public class ParameterIn : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int num = 10;
            Debug.Log($"[1] : {num}");  // [1] 10

            PrintNumber(num);

            Debug.Log($"[3] : {num}");  // [3] 10
        }

        // 매개변수로 전달받은 정수(num)를 출력하는 함수
        void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"[2] : {num}");  // [2] 20
        }
    }
}

/*
매개변수() - 값이 전달되는 방법을 구분
[1] 값 전달 방법         (int num)
[2] 참조 전달 방법       (ref int num)
[3] 반환형 전달 방법     (out int num)
[4] 가변형 전달 방법     (params int[] numbers)

코드영역 : 게임 실행중 변경이 불가한 부분 저장 - 상수(10, 100), 클래스 선언, 변수 선언, 읽기 전용
데이터 영역 : 정적 멤버 변수(필드)
힙 영역 : 인스턴스(객체)의 실체가 있는 영역. new
스텍 영역 : 함수의 실행 메모리 영역
*/