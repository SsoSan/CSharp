using UnityEngine;

// index(인덱스) : 몇 번째의 방, [ ] 안에 들어가는 변수, 값
public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 그기가 3인 정수형 배열 선언하고 초기화
        int[] numbers = { 1, 2, 3 };
        // number[0] -> 1, number[1] -> 2, number[2] -> 3

        // 배열의 index를 관리하는 변수 / 항상 0으로 초기화 / index의 범위는 0 ~ n-1(2)
        int index = 0;

        Debug.Log(numbers[index++]);    // 1 : numbers[0] => 1, index: 1
        Debug.Log(numbers[index++]);    // 2 : numbers[1] => 2, index: 2
        Debug.Log(numbers[index++]);    // 3 : numbers[1] => 3, index: 3

        Debug.Log("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");

        Debug.Log(numbers[--index]);    // 3 : index: 2 => numbers[2] => 3
        Debug.Log(numbers[--index]);    // 2 : index: 1 => numbers[1] => 2
        Debug.Log(numbers[--index]);    // 1 : index: 0 => numbers[0] => 1

    }
}
