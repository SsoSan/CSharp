using UnityEngine;

namespace Interface
{
    public interface IAnimal
    {
        void Eat();
    }

    public interface IDog
    {
        void Cry();
    }

    public class Cat
    {

    }

    // 다른 클래스 상속과 함께 인터페이스의 다중 상속 가능
    public class MyCat : Cat, IAnimal
    {
        public void Eat() { }
    }

    // 다른 인터페이스 상속과 함께 인터페이스의 다중 상속 가능
    public class Dog : IAnimal, IDog
    {
        public void Eat()
        {
            Debug.Log("야미");
        }
        public void Cry()
        {
            Debug.Log("멍!");
        }
    }
}