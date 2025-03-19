using UnityEngine;

namespace Method
{
    struct Point
    {
        public int x;
        public int y;
    }
    // [1] 값 전달 방법 : 구조체
    public class ParameterIn2 : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Point point;
            Point point = new Point();
            point.x = 10;

            Debug.Log($"[1] point.x : {point.x}");  // [1] 10

            PrintPoint(point);

            Debug.Log($"[3] point.x : {point.x}");  // [3] 10
        }

        // 매개변수로 입력받아 구조체에 포함 되어있는 변수를 출력하는 함수
        void PrintPoint(Point point)
        {
            point.x = 20;

            Debug.Log($"[2] point.x : {point.x}");  // [2] 20
        }
    }
}