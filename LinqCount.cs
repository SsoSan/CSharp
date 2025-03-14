using UnityEngine;
using System.Linq;

// Linq : 확장 메서드
public class LinqCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 정수형 배열의 요소수 개수 얻어오기
        int[] numbers = { 1, 2, 3 };

        // numbers.Length
        int count = numbers.Count();

        Debug.Log($"numbers 배열의 개수는 {count}");
    }
}
