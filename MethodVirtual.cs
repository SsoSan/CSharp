using UnityEngine;

namespace Override
{
    public class MethodVirtual : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            /*
            // Animal 클래스의 인스턴스 생성
            Animal animal = new Animal();
            animal.Eat();

            // Dog 클래스의 인스턴스 생성
            Dog dog = new Dog();
            dog.Eat();

            // Cat 클래스의 인스턴스 생성
            Cat cat = new Cat();
            cat.Eat();
            
            Animal Dog2 = new Dog();
            Dog2.Eat();
            */

            // 업 캐스팅 : 다형성
            // 엄빠클래스(Animal)의 변수에 새끼클래스의 인스턴스 생성
            Animal aDog = new Animal();
            aDog.Eat();

            Animal bCat = new Animal();
            bCat.Eat();
        }
    }
}