using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using Unity.Android.Gradle.Manifest;

public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] score = { 90, 65, 78, 50, 95 };
        // 평균점수 = 총점 / 점수의 개수

        double average = 0;
        int sum = 0;
        int count = 0;

        for (int i = 0; i < score.Length; i++)
        {
            if (score[i] >= 70 && score[i] <= 95)
            {
                sum = sum + score[i];
                count++;
            }
        }

        if(count > 0)
        {
            average = sum / (double)count;
        }

        Debug.Log($"평균점수 : {average:0.00}");
    }
}

/*
[Q]
입력데이터 {90, 65, 78, 50, 95}
국어점수중 70점 이상이고 95점 이하인 점수들의 평균을 구하라

[output] - 소수점 이하 2자리까지
평균점수 : average
*/