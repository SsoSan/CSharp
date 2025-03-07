using UnityEngine;

//1, 2, 3, 4, 5
//5, 4, 3, 2, 1
public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1부터 5까지 1씩 증가
        //초기식
        int i = 1;

        //조건식
        while (i <= 5)
        {
            //반복실행문
            Debug.Log($"카운트다운 : {i}");

            //증감식
            i++;
        }
        Debug.Log("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");

        //[2] 5부터 1까지 1씩 감소
        int j = 5;

        while(j >= 1)
        {
            
            Debug.Log($"카운트다운 : {j}");

            j--;
        }
    }
}
