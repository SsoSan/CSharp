using UnityEngine;

namespace Inheritance09
{
    // 추상클래스 : 자신을 상속받는 새끼클래스에서 정제로 지정한 기능(메서드)를 구현하도록
    // 추상메서드 : 지정한 기능(메서드)
    // public abstract void (추상메서드 이름)();
    public abstract class GeneralManager
    {
        // 추상메서드 : 메서드 구현 부분(코드블럭, 본문)을 생략
        public abstract void SayTalk();
    }

    // 추상클래스(GeneralManager)를 상속받는 새끼클래스
    public class Person : GeneralManager
    {
        // 상속받은 추상메서드 구현 부분
        // public override void (추상메서드이름)()
        public override void SayTalk()
        {
            Debug.Log("왕관을 쓰려는자, 그 무게를 견뎌라");
        }
    }
}