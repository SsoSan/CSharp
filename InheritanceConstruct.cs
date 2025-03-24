using UnityEngine;

namespace Inheritance06
{
    public class InheritanceConstruct : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Child 클래스의 인스턴스 생성
            Child child1 = new Child();
            child1.SayName();

            Child child2 = new Child("바쁘다 바빠!!!");
            child2.SayName();
        }
    }
}