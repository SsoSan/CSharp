using UnityEngine;

public class ArrayOne2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1 - 1] 1차원 배열 선언, 요소수(개수) 생성, 값 초기화 동시
        // int[] intArray = new int[3] { 1, 2, 3 };    //순서대로 값이 들어감
        // [1 - 2] 1차원 배열 선언, 요소수(개수) 생성하면서 크기 생략, 값 초기화 동시
        // int[] intArray = new int[] { 1, 2, 3, 4 };    //[]생략시 {}안에 입력하는 수 만큼 자동으로 생성
        // [1 - 3] 1차원 배열 선언, 값 초기화 동시
        int[] intArray = { 1, 2, 3, 4 };    //new 효과가 있음

        //[4] 배열 사용
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"{i}번째 방의 값은 : {intArray[i]}");
        }
    }
}
