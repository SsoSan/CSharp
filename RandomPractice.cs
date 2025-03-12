using UnityEngine;

// 로또 번호 생성기
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Random 클래스의 객체 생성
        System.Random random = new System.Random();

        // 배열 변수 선언 및 요소수 생성
        int[] numbers = new int[6];

        int number = 0;     // 랜덤값을 저장하는 변수
        bool flag = false;  // 중복 검사해서 중복이면 true, 아니면 false

        for (int i = 0; i < 6; i++)
        {
            // 1 ~ 46랜덤 값을 받아온다
            number = random.Next(1, 46);

            // 중복 체크 - number와 먼저 출력된 번호 비교
            flag = false;
            if(i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;
                    }
                }
            }

            if (flag == false)   // 중복이 아니면
            {
                numbers[i] = number;
            }
            else   // 중복이면 다시 계산하기 위해 인덱스를 조정
            {
                i--;
            }
        }

        // 로또번호 출력
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log($"로또번호 : [{numbers[i]}]");
        }
    }
}

/*
// 중복 비교
numbers[0] = X
numbers[1] = [0]
numbers[2] = [0], [1]
numbers[3] = [0], [1], [2]
numbers[4] = [0], [1], [2], [3]
numbers[5] = [0], [1], [2], [3], [4]
*/

/*
[Q]
로또 번호 생성기 가보자고
[1] 6개 번호
[2] 1 ~ 45번 사이의 랜덤 번호
[3] 중복된 숫자가 나오지 않게

[output] 조건에 맞는 번호 6개 출력
1
2
3
4
5
6
*/