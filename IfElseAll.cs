using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //하나의 정수를 입력 받아서 

        int number = 21;

        //짝수 판별식
        if (number % 2 == 0)
        {
            Debug.Log($"{number}는 짝수");
        }

        //홀수 판별식
        if (number % 2 != 0)
        {
            Debug.Log($"{number}는 홀수");
        }
        else
        {
            Debug.Log($"{number}는 짝수");
        }

        //3의 배수, 5의배수, 7의 배수 판별식
        if (number % 3 == 0)
        {
            Debug.Log($"{number}는 3의 배수");
        }

        if (number % 5 == 0)
        {
            Debug.Log($"{number}는 5의 배수");
        }

        if (number % 7 == 0)
        {
            Debug.Log($"{number}는 7의 배수");
        }

        /*else
        {
            Debug.Log($"{number}는 3,5,7의 배수가 아닌 수");
        }*/
    }
}