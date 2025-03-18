using UnityEngine;

namespace Constructor
{
    public class Car
    {
        // 필드
        private string color;

        // 기본 생성자
        public Car()
        {
            color = "흰색";
            Debug.Log($"자동차를 {color}으로 랩핑");
        }

        // 매개변수가 있는 생성자
        public Car(string _color)
        {
            this.color = _color;
        }

        // 메서드
        public void Run()
        {
            Debug.Log($"{color} 자동차가 질주하농");
        }

        // 소멸자
        ~Car()
        {
            Debug.Log($"{color} 자동차를 딜러한테 넘겼농");
        }
    }
}