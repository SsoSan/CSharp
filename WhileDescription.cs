using UnityEngine;

//안녕하세요를 3번 출력하는 프로그램 구현
public class WhileDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for(int i = 0; i < 3; i++)    //반복 횟수 : 3
        //for(int i = 1; i < 4; i++)    //반복 횟수 : 4 - 1
        //for(int i = 1; i <= 3; i++)   //반복 횟수 : 3 - 1 + 1

        /*  (초기식; 조건식; 증감식)
        for (int i = 0; i < 3; i++)
        {
            //반복실행문
            Debug.Log("안녕하세요");
        }
        */

        //[1]초기식
        int i = 0;

        //[2]조건식
        while(i < 3)
        {
            //반복실행문
            Debug.Log("안녕하세요");

            //증감식
            i++;
        }

        //int i = 0 -> 조건식 판별(참) i = 0 -> 출력 -> 증감식 i = 1 -> 조건식 판별(참) i = 1 -> 출력
        //증감식 i = 2 -> 조건식 판별(참) i = 2 -> 출력 -> 증감식 i = 3 -> 조건식 판별(거짓) -> while문 종료
    }
}

/*
while문(반복문)
 - 조건식이 true면 반복문을 실행
 - 조건식이 false면 while문 종료

while(조건식)
{
    //반복 실행문
    //조건식에 들어가는 변수 증감식
}

조건식 판별(참) -> 반복문 실행 -> 조건식 판별(참) -> 반복문 실행 -> 조건식 판별(거짓) -> while문 종료
*/