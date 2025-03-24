using UnityEngine;

namespace Override
{
    // 엄빠클래스
    public class Animal
    {
        // virtual이 표시 된 메서드 : 가상메서드
        public virtual void Eat() => Debug.Log("Animal Eat");
    }

    // 새끼클래스
    public class Dog : Animal
    {
        public override void Eat()
        {
            Debug.Log("댕댕이가 츄베릎!");
        }
    }

    // 새끼클래스
    public class Cat : Animal
    {
        public override void Eat()
        {
            // 엄빠메서드에서 구현 된 내용을 모두 실행
            base.Eat();
            
            // 새로 추가 된 내용 실행
            Debug.Log("우리집 고양이 츄르를 좋아해!");
        }
    }
}