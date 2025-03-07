using UnityEngine;

//while문을 이용해서 1부터 n(100)까지의 정수중에서 짝수의 합을 구하는 프로그램 구현
public class WhileSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //결과를 저장하는 변수
        int n = 100;
        int sum = 0;

        //초기식
        int i = 1;

        //조건식
        while (1 <= n)
        {
            if(i % 2 == 0)
            {
                //반복실행문
                sum = sum + i;

                //증감식
                i++;
            }
        }

        Debug.Log($"1부터 {n}까지 짝수의 합은 : {sum}");
    }
}
