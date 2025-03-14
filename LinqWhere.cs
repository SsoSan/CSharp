using UnityEngine;
using System.Linq;
using System.Collections.Generic;

//LinqWhere (Where절, 조건절)
public class LinqWhere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 정수형 배열 numbers의 요소수 3보다 크고 짝수인 수들 구하기 + 리스트 넣기
        int[] numbers = { 1, 2, 3, 4, 5 };

        // n은 3보다 큰 n을 가져오셈
        //IEnumerable<int> newNumbers = numbers.Where(n => n > 3);
        List<int> newNumbers = numbers.Where(n => n > 3 && n % 2 == 0).ToList();

        foreach (var n in newNumbers)
        {
            Debug.Log(n);
        }
    }
}
