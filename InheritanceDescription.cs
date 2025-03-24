using UnityEngine;

namespace Inheritance
{
    public class InheritanceDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Child 클래스의 인스턴스 생성
            Child child = new Child();
            child.Foo();    // 엄빠클래스의 메서드 호출
            child.Bar();    // 새끼클래스의 메서드 호출
        }
    }
}

/*
Inheritance(상속)
 - 엄빠클래스가 새끼클래스에게 기능을 물려줘서 사용하도록 혀라~
부모클래스
 - Base(베이스)클래스, 슈퍼클래스, 기본클래스 (새끼클래스를 여러개 가질 수 있음)
 - 새끼클래스들의 공통 기능을 모아놓은 클래스
새끼클래스 : Sub(서브)클래스
똥강아지클래스 : 새끼의 새끼 클래스 - 엄빠 + 새끼 클래스의 기능을 모두 물려받음
*/