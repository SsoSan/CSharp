using UnityEngine;

// 만약 score가 60점 이상이면 "합격" 이라고 출력, 
// score 61점
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        if(score가 60점 이상)
        {
            "합격" 이라고 출력
        }
        */

        int score = 61;

        if (score >= 60) //조건문이 참이면 블록안에 있는 실행문 실행
        {
            //실행문
            Debug.Log("합격");
        }
    }

}

/*
if문 - 조건문
조건식이 참일때만 실행문이 실행됩니다
조건식이 거짓이면 실행문을 실행하지 않습니다

//만약 조건식이 참이면 {} 안에 있는 실행문을 실행하라
if(조건식)
{
    //실행문1
    //실행문2
    //.....
}

if(bool)
{
    //실행문1
    //실행문2
    //.....
}
*/