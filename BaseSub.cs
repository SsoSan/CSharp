using UnityEngine;

namespace Inheritance
{
    public class BaseSub : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // SubClass 클래스의 인스턴스 생성
            SubClass sub = new SubClass();
            sub.Do();   // Base 클래스에 정의 된 (public, protected)메서드 사용가능
        }
    }
}