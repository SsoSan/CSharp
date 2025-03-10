using UnityEngine;

//ForEach : 배열에 저장된 값들을 순서대로 모두 가져와서 사용
public class ArrayForEach : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //배열 요소들의 값을 모두 가져와서 총ㅎ바을 구하는 프로그램 구현
        float[] arr = { 10.5f, 20.1f, 30.3f };
        float sum = 0f;

        /*
        for (int i = 0; i < 3; i++)
        {
            sum = sum + arr[i];
        }
        */

        foreach (float f in arr)
        {
            //반복실행문
            sum = sum + f;
        }

        Debug.Log($"총합은 {sum}");
    }
}


