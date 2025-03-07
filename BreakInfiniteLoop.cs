using UnityEngine;

// break로 무한루프 빠져나오기
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //무한루프, 무한반복
        /*
        for(; ; )
        {
            
        }
        while (true)
        {
            
        }
        */

        int number = 0;

        //number가 5이상이면 while문 종료
        while (true)
        {
            //반복실행문
            Debug.Log(number);

            //증감식
            number++;

            if(number >= 5)
            {
                break;
            }
        }
    }
}
