using Unity.VisualScripting;
using UnityEngine;

// [1] 구조체 정의, 선언 : 고객의 데이터를 관리하는 구조체
struct UserInfo
{
    public string name; // 고객 이름
    public int age;     // 고객 나이
    //...
}

public class StructArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 구조체 변수 선언
        UserInfo info;

        // [2] 초기화
        info.name = "홍길동";
        info.age = 20;

        // [3] 사용
        //PrintUserInfo(info.name, info.age);
        PrintUserInfo(info);

        //______________________________배열______________________________________
        // [1] 구조체의 배열 변수 선언, 배열의 요소수(크기) 생성
        UserInfo[] userInfos = new UserInfo[2];

        // [2] 구조체 배열의 초기화
        userInfos[0].name = "백두산";
        userInfos[0].age = 22;
        userInfos[1].name = "임꺽정";
        userInfos[1].age = 33;

        // [3] 구조체 배열 사용
        for(int i = 0; i < userInfos.Length; i++)
        {
            //PrintUserInfo(userInfos[i].name, userInfos[i].age);
            PrintUserInfo(userInfos[i]);
        }
    }

    //고객의 명단을 출력하는 함수
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name} 고객님의 나이는 {age}살 입니다");
    }

    void PrintUserInfo(UserInfo UserInfo)
    {
        Debug.Log($"{UserInfo.name} 고객님의 나이는 {UserInfo.age}살 입니다");
    }
}
