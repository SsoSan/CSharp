using UnityEngine;
using System.Collections.Generic;

namespace GenericClass
{
    // 제네릭클래스 활용 설계
    public class Hello<T>
    {
        // 필드
        private T _message;

        // 생성자
        public Hello()
        {
            this._message = default(T);
        }

        public Hello(T message)
        {
            this._message = message;
        }

        // 메서드
        public void Say(T message)
        {
            Debug.Log($"{message}");
        }

        public T GetMessage() => this._message;
    }
}