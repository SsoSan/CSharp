using UnityEngine;

namespace Inheritance08
{
    // 추상클래스
    public abstract class ParentClass
    {
        public int Id { get; set; }
        public bool Active { get; set; }
    }

    // 새끼클래스 : 추상클래스(ParentClass) 를 상속
    public class ChildClass : ParentClass
    {
        public string Name { get; set; }
    }
}