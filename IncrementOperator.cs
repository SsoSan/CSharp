using UnityEngine;

//IncrementOperator(증가연산자) : 정수형 변수의 값을 1 증가
public class IncremantOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 100;

        //1 증가식
        //num = num + 1;
        //num += 1;
        ++num;      //101

        Debug.Log("num: " + num);
    }
}