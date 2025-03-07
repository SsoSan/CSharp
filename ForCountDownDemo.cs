using UnityEngine;

// 1, 2, 3, 4, 5
// 5, 4, 3, 2, 1
public class ForCountDownDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1부터 5까지 1씩 증가
        for (int i = 1; i < 5 + 1; i++)
        {
            Debug.Log($"증가 Countdown: {i}");
        }
        Debug.Log("===================================");

        //[2] 5부터 1까지 1씩 감소
        /*for(int i=5; i > 0; i--)
        {
            Debug.Log($"감소 Countdown: {i}");
        }*/
        // 5, 4, 3, 2, 1

        // 0, 1, 2, 3, 4
        for (int i = 0; i < 5; i++)  //5번 반복
        {
            Debug.Log($"감소 Countdown: {(5 - i)}");
        }

    }
}