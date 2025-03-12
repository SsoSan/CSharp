using UnityEngine;

// Random 클래스 : 랜덤값과 관련된 변수들, 메서드들이 있는 클래스
public class RandomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Random 클래스의 객체 생성
        System.Random random = new System.Random();

        // 임의의 정수값 구해버리기
        Debug.Log(random.Next());

        // 0 ~ 4 중 하나의 값 구해버리기
        Debug.Log(random.Next(5));

        // 1 ~ 9 중 하나의 값 구해버리기
        Debug.Log(random.Next(1, 10));

        // Next => Instance함수
    }
}
