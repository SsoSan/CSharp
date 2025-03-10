using UnityEngine;

// 가변형 배열 : 배열의 길이 = 가변
public class ArrayTwo3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 2차원 배열 선언, 첫번째 요소수(크기)만 생성
        int[][] intArray = new int[2][];

        // [2] 2차원 배열 두번째 요소수(크기) 생성, 초기화   //첫번쨰 두번째 각각 따로 생성
        intArray[0] = new int[3] { 1, 2 ,3 };
        intArray[1] = new int[2] { 4, 5 };

        //배열의 길이
        Debug.Log($"배열의 길이 : {intArray.Length}");

        // [4] 2차원 배열 사용
        for (int i = 0; i < 2; i++)
        {
            Debug.Log("♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥");

            for (int j = 0; j < 3; j++)
            {
                Debug.Log(intArray[i][j]);
            }
        }
    }
}
