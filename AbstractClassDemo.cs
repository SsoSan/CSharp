using UnityEngine;

namespace Inheritance08
{
    public class AbstractClassDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // 추상클래스는 인스턴스 생성 불가
            // ParentClass parent = new ParentClass();

            ChildClass child = new ChildClass() { Id = 1, Active = true, Name = "홍길동" };
            if (child.Active == true)
            {
                Debug.Log($"{child.Id} - {child.Name}");
            }
        }
    }
}

/*
AbstractClass(추상클래스)
 - 자신을 상속받는 새끼 클래스에서 강제로 기능을 추가
 - 새끼클래스는 엄빠클래스가 지정한 기능을 구현하도록 강제
 - 인스턴스(객체)를 만들수 없음
 - 다른 클래스의 엄빠클래스만 사용 가능

추상클래스 형식

public abstract class (추상클래스 이름)
{
    //
}
*/