using UnityEngine;

namespace Property
{
    public class PropertyDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] Developer 클래스의 인스턴스 생성
            Developer dev = new Developer();

            // [2] 속성에 값 설정
            dev.Name = "홍길동";

            // [3] 속성 값 사용
            Debug.Log(dev.Name);
        }
    }
}

/*
Property(속성) : 필드의 값을 읽기, 쓰기, 연산 등의 방법을 제공하는 클래스 멤버
 - 클래스의 속성을 나타내는 멤버
 - 필드는 기본적 private(외부 접근 제한)
 - 속성은 접근 제한된 필드를 외부에서 읽기, 쓰기가 가능하도록 함
 - 속성 이름의 맨 앞 알파벳은 대문자

Property(속성) 형식

public [반환타입] 속성이름 { get; set;}
*/