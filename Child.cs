using UnityEngine;

namespace Inheritance06
{
    // 새끼클래스
    public class Child : Parent
    {
        // 생성자
        public Child() : this("바쁘다 바빠 현대사회")
        {

        }

        public Child(string message) : base(message)
        {

        }

        public void SayName()
        {
            Debug.Log(base.Word);
        }
    }
}