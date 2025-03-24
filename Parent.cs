using UnityEngine;

namespace Inheritance06
{
    // 엄빠클래스
    public class Parent
    {
        public string Word { get; set; }

        // 생성자
        public Parent(string word)
        {
            this.Word = word;
        }
    }
}