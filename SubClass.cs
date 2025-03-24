using UnityEngine;

namespace Inheritance04
{
    // 새끼클래스
    public class SubClass : BaseClass   // : (콜론)으로 엄빠클래스 지정
    {
        public void PrintDebug()
        {
            base.PrintLog(); // Base 키워드로 엄빠 멤버에 접근
        }
    }
}