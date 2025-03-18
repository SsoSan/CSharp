using UnityEngine;

namespace Constructor
{
    public class DestructorDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Car 클래스의 인스턴스(흰색, 푸른색, 붉은색) 생성하고 질주
            Car whiteCar = new Car();
            whiteCar.Run();

            // whiteCar 매매 : GC에서 알아서 소멸

            Car blueCar = new Car("푸른색");
            blueCar.Run();

            Car redCar = new Car("붉은색");
            redCar.Run();
        }
    }
}