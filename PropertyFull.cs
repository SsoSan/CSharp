using UnityEngine;

namespace Property
{
    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] Person 클래스의 인스턴스 생성
            Person person = new Person();

            // [2] 메서드를 이용해서 name값 저장 및 사용
            person.SetName("홍길동");

            Debug.Log(person.GetName());

            // [3] Property(속성)를 이용하여 필드(name)값 저장 및 사용
            // Name 속성의 set 기능
            person.Name = "백두산";

            // Name 속성의 get 기능
            Debug.Log(person.Name);
        }
    }
}