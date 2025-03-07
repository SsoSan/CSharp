using UnityEngine;

// nariable(변수) : 프로그램에서 사용하는 데이터를 저장해 놓는 그릇
// array(배열) : 하나의 이름으로 가튼 데이터 형식을 여러개 보관해 놓는 그릇
// 선언 : 데이터타입[] 변수명(이름) : 
// 크기지정 : 변수명(이름) : new 데이터타입[크기]
public class ArrayDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;

        //[1] 배열 선언
        int[] numbers;

        //[2] 배열의 요소수 생성 - 그릇 개수 지정 - 크기
        numbers = new int[10];  // 0 ~ n-1

        //[3] 배열의 저장, 대입 - 초기화
        numbers[0] = 3840;
        numbers[1] = 2160;

        //[4] 배열의 사용
        Debug.Log(numbers[0] * numbers[1] * numbers[2]);
        Debug.Log(n);
    }
}
