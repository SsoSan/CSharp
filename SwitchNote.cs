using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 선언문
        int x = 1;

        //switch(조건) : Data 값 판별
        switch (x)
        {
            case 1:
                Debug.Log("x는 1 입니다");  //[2] 실행문1
                break;

            case 2:
                Debug.Log("x는 2 입니다");  //[3] 실행문2
                break;
        }

        //[4] 실행문3
        Debug.Log("프로그램 종료");

        //int x = 2;
        // [1] -> [3] -> [4]
        //int x = 1;
        // [1] -> [2] -> [4]
    }
}

/*
switch문 : 조건문 - 선택문

switch(조건) : Data 값 판별
{
    case 1번:
        //실행문1
        break;

    case 2번:
        //실행문2
        break;

    case 3번:
        //실행문3
        break;

    defalt: //모든 case가 아니면
        //실행문4
        break;
}

if(조건식) : 조건식을 참, 거짓 판별
{
    실행문1
}
else
{
    실행문2
}

*/