using UnityEngine;

namespace Inheritance05
{
    public class Car
    {
        // 필드
        private string name;

        // 생성자 - 매개변수를 통해 name 초기화
        public Car(string _name)
        {
            this.name = _name;
        }

        // 메서드
        public void Run() => Debug.Log($"{name}이(가) 달린다");
    }
}