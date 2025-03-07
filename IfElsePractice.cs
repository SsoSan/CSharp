using UnityEngine;

public class IfEslePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 65;
        string medal = "";

        //[1]score가 90이상이면 금메달
        if (score >= 90)
        {
            medal = "금메달";
        }
        else // 0~89
        {
            //[2] 80이상이면 은메달
            if (score >= 80)
            {
                medal = "은메달";
            }
            else // 0~79
            {
                //[3] 70 이상이면 동메달
                if (score >= 70)
                {
                    medal = "동메달";
                }
                else //0~69
                {
                    medal = "노메달";
                }
            }
        }

        Debug.Log($"{medal}를 수상하였습니다");
    }
}


/*
[Q]
score가 90이상이면 금메달 출력, 80이상이면 은메달 출력
70 이상이면 동메달 출력, 그외 나머지는 노메달 출력
score는 85점

[output]
()를 수상하였습니다

*/