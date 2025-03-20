using System.Drawing;
using UnityEngine;

namespace Property
{
    public class PropertyDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] public 메서드 Get, Set 이용 - 붉은 색 자동차
            Car car1 = new Car();
            car1.SetColor("Red");

            Debug.Log(car1.GetColor());

            // [2] public 속성 이용 - 흰 색 자동차
            Car car2 = new Car();
            car2.SetColor("White");

            Debug.Log(car2.Color);

            // [3] 읽기 전용
            Car car3 = new Car();
            // car3.Maker = "토요타";
            Debug.Log(car3.Maker);

            //
            Car myCar = new Car();
            myCar.Name = "꼬붕이";

            Debug.Log(myCar.Name);
        }
    }
}