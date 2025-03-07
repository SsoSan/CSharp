using UnityEngine;

// &&, ||
public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1234;

        //조건식 2개 : number가 1234와 같냐?, number가 1000 이상이냐?
        //2가지 조건을 모두 만족하면(&&) 맞습니다 출력
        if (number == 1234 && number >= 1000)
        {
            Debug.Log("맞습니다");
        }

        //조건식 2개 : number가 1234와 같냐?, number가 1000 이하이냐?
        //2가지 조건중 하나라도 만족하면(||) 실행문 실행
        if (number == 1234 || number <= 1000)
        {
            Debug.Log("하나라도 참이면 참");
        }
    }
}