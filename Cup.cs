using UnityEngine;
using System.Collections.Generic;

namespace GenericClass
{
    public class Water { }
    
    public class Coffee { }

    // 제네릭클래스 만들기 - 클래스이름<T>
    public class Cup<T>
    {
        public T Contents { get; set; }

        // public Water Contents { get; set; }
        // public int Contents { get; set; }
        // public string Contents { get; set; }

        // 매개변수로 입력받은 T형식의 데이터를 출력
        public void PrintData(T data)
        {
            Debug.Log($"{data}");
        }
    }
}