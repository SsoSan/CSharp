using UnityEngine;

namespace Property
{
    // 읽기 전용 속성 만들기 - (외부에서)쓰기 막기
    public class Page
    {
        public string Message { get; private set; } = "읽기 전용 속성";
    }
}