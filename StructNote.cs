using UnityEngine;

// 고객 데이터를 관리하는 구조체
// [1] 구조체 정의, 선언
struct BusinessCard
{
    public string name;     // 고객 이름
    public int age;         // 고객 나이
    public string address;  // 고객 주소
}
public class StructNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 구조체 형식의 변수 선언
        BusinessCard myCard;

        // [3] 구조체에 속해있는 데이터들의 초기화
        myCard.name = "홍길동";
        myCard.age = 20;
        myCard.address = "대한민국";

        // [4] 구조체 사용
        Debug.Log($"이름 : {myCard.name}, 나이 : {myCard.age}, 주소 : {myCard.address}");
    }
}
