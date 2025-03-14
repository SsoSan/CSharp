using System.Linq;
using UnityEngine;

public class MaxPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        int[] numbers = { -2, -5, -3, -7, -1 };

        int max = 0;

        max = numbers.Max();

        Debug.Log($"최대값 : {max}");
        */
        
        int[] data = { -2, -5, -3, -7, -1 };

        // for문 이용 최대값을 저장하는 변수
        // max의 초기화 값 : max의 데이터 타입이 가지는 값중 가장 작은 값
        int max = int.MinValue;

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] > max)
            {
                max = data[i];  // 두 수 비교 후 큰값을 max에 저장
            }
        }

        Debug.Log($"최대값 : {max}");
    }
}

/*
입력데이터 : { -2, -5, -3, -7, -1 }
입력 데이터 중에서 최대값을 구하라

[output]
최대값 : -1
*/