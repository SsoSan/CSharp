using UnityEngine;

namespace Interface
{
    public class InterfaceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Dog 클래스의 인스턴스 생성
            Dog dog = new Dog();
            dog.Eat();  // IAnimal 인터페이스 상속받아 구현
            dog.Cry();  // IDog 인터페이스 상속받아 구현
        }
    }
}