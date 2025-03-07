using UnityEngine;


public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //dowhile
        //[1]초기식
        int i = 0;

        do
        {
            //반복실행문
            Debug.Log("안녕하세요");

            //[2]증감식
            i++;

          //[3]조건식
        } while (i < 3);

        //i = 0; -> 출력 -> i = 1; -> i < 3(참) -> 출력 -> i = 2 -> i < 3(참) -> 출력
        //i = 3 -> i < 3(거짓) -> dowhile문 종료
    }
}

/*
dowhile문(반복문)
먼저 반복실행문 1번 실행한다
 - 조건식이 true면 반복문을 실행
 - 조건식이 false면 while문 종료

do
{
    //반복실행문
} while(조건식)
*/