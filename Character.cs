using UnityEngine;

namespace Override
{
    // 플레이어, 몬스터(슬라임, 좀비, 고블린, ...)
    // 모든 캐릭터의 추상 엄빠클래스(캐릭터들이 가지고 있는 공통 특성, 기능)
    public abstract class Character
    {
        public abstract int GetTotalAttack();

        public int health;
        public int baseAtk;

        // 생성자 - 멤버 초기화
        public Character(int hp, int atk)
        {
            this.health = hp;
            this.baseAtk = atk;
        }

        // 매개변수로 나를 공격하는 캐릭터 객체를 전달 해준다
        public void TakeDamage(Character other)
        {
            health -= other.GetTotalAttack();
        }
    }

    // 플레이어
    public class Player : Character
    {
        public Player() : this(10, 20) { }
        public Player(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            // 장비
            // 스킬
            // 상성

            return total;
        }
    }

    // 몬스터 : 슬라임, 좀비, 고블린, ... 등의 엄빠클래스
    public class Monster : Character
    {
        // 생성자
        public Monster(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            // 스킬
            // 상성

            return total;
        }

        // 몬스터들의 공통 기능 구현
        // ...
    }

    // 고블린
    public class Goblin : Monster
    {
        // 고블린 특성
        public int PosX, PosY;

        // 생성자
        public Goblin(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            // 스킬
            // 상성

            return total;
        }

        public void SetPosition(int x, int y)
        {
            this.PosX = x;
            this.PosY = y;
        }
    }

    // 스켈레톤
    public class Skeleton : Monster
    {
        // 생성자
        public Skeleton(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            // 스킬
            // 상성

            return total;
        }
    }

    // 좀비
    public class Zombie : Monster
    {
        // 생성자
        public Zombie(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            // 스킬
            // 상성

            return total;
        }
    }
}