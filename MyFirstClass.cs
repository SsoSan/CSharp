using UnityEngine;

// 정적 메서드 호출, 인스턴스 메서드 호출
public class MyFirstClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정적(static) 메서드 호출 - StaticMethod(); 호출
        // 호출 방법 : 클래스이름.메서드이름();
        ClassMember.StaticMethod();

        // [2] 인스턴스(Instance) 메서드 호출 - InstanceMethod(); 호출
        // 호출 방법 : 클래스의 객체(개체, Instance), (클래스의 변수 선언) 생성, new 키워드를 이용하여 새로운 객체 생성
        // 클래스이름 객체이름 = new 클래스이름();
        // 객체이름.메서드이름
        ClassMember member = new ClassMember();
        member.InstanceMethod();
    }
}
