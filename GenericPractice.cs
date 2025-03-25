using UnityEngine;

namespace GenericClass
{
    public class GenericPractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // MyList 클래스의 인스턴스 생성 - int 전용
            MyList<int> numbers = new MyList<int>(3);
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }

            // MyList 클래스의 인스턴스 생성 - string 전용
            MyList<string> names = new MyList<string>(3);
            names[0] = "홍길동";
            names[1] = "백두산";
            names[2] = "장길산";

            foreach (var name in names)
            {
                Debug.Log(name);
            }
        }
    }
}