using UnityEngine;

namespace Inheritance07
{
    // 엄빠클래스
    public class Animal
    {
        public void Eat() => Debug.Log("고항 타베마스");
    }

    // 새끼클래스 : Animal 클래스를 엄빠로 지정
    // sealed : Cat 클래스를 봉인(sealed) 클래스로 지정
    // 최종 클래스가 되어 상속 X, 자신의 클래스를 엄빠로 지정하지 못하도록 막음
    public sealed class Cat : Animal
    {

    }

    /*
    // 새끼클래스 : Cat 클래스를 엄빠로 지정
    public sealed class MyCat : Cat
    {
        // sealed가 붙은 클래스는 엄빠로 지정 불가능
    }
     */
}