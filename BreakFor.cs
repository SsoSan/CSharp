using UnityEngine;

// break; : 반복문(for, while)에서 코드블록({ })을 빠져나오는 명령문
// 반복문 안에서 break문을 만나면 즉시 반복문을 강제 종료
// "안녕하세요"를 5번 하는 프로그램 구현
public class BreakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // "안녕하세요"를 5번 하는 프로그램 구현
        // i = 2일 때 for문을 종료
        for (int i = 0; i < 5; i++)
        {
            /*
            if (i == 2)
            {
                break;      <-코드의 위치에 따라 결과는 천차만별
            }
            */

            // 반복실행문
            Debug.Log("안녕하세요");

            if (i == 2)
            {
                break;
            }
        }

        // i = 0 → i < 5(참) → 출력 → i == 2(거짓) → i = 1 → i < 5(참) → 출력
        // i == 2(거짓) → i = 2 → i < 5(참) → 출력 → i == 2(참) → break; → for문 종료
    }
}
