using UnityEngine;

namespace InterfaceTest
{
    public class CarWorld : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] Car 클래스의 인스턴스 생성
            Car campingCar = new Car("캠핑카");
            campingCar.Run();

            // [2] 속성
            Car sportCar = new Car();
            sportCar.Name = "스포츠카";
            sportCar.Run();

            // [3] 인덱스
            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";

            foreach (var c in cars)
            {
                Debug.Log(c);
            }
        }
    }
}

/*
객체지향 프로그래밍
 - 추상화
 - 캡슐화
 - 상속
 - 다형성
*/