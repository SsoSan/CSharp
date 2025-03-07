using UnityEngine;

// 1부터 100까지의 정수중에서 3의 배수를 제외한 나머지 수의 합을 구하는 프로그램 구현
public class ContinueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        for(int i = 1; i <= n; i++)
        {
            // 3의 배수 판별식
            if(i % 3 == 0)
            {
                continue;
            }

            // 판별식이 증감식 다음으로 나오면 판별하지 않음
            sum = sum + i;
        }

        Debug.Log($"1부터 {n}까지의 정수중에서 3의 배수를 제외한 나머지 수의 합은 : {sum}");
    }
}
