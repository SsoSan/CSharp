using UnityEngine;
using System.Linq;
public class LinqMinMax : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 정수형 배열 numbers의 요소중 최소 값, 최대 값 구하기
        int[] numbers = { 76, 167, 832 };

        // 변수 초기화
        int max = 0;
        int min = 0;

        //
        max = numbers.Max();
        min = numbers.Min();

        Debug.Log($"numbers 최대값 : {max}, 최소값 : {min}");
    }
}
