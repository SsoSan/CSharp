using UnityEngine;
using static Unity.VisualScripting.Dependencies.Sqlite.SQLite3;

namespace Override
{
    public enum CarType
    {
        전기,
        내연기관,
        하이브리드
    }

    // 엄빠클래스 - 추상클래스(인스턴스 생성 불가)
    public abstract class CarBase
    {
        public abstract void Left();    // 추상메서드, 본문(구현 내용) 없음

        // 접근제한자 public - 새끼클래스와 외부 클래스에서 접근, 사용 가능
        public void Back() => Debug.Log("후진");

        // 접근제한자 protected - 자식클래스 에서만 접근, 사용가능
        // 접근제한자 private - 외부 모든 클래스에서 접근 불가
        // private 을 선언한 클래스 코드블록 안에서만 사용 가능
        protected string LeftMessage { get; private set; } = "좌회전";
    }

    // 새끼클래스
    public class Car : CarBase
    {
        // 모든 자동차의 공통 속성
        public CarType Style { get; private set; }

        // 생성자 - 매개변수를 입력받아 자동차 CarType 초기화
        public Car(CarType ctype)
        {
            // this 키워드를 자신의 멤버에 접근(생략 가능)
            this.Style = ctype;
        }

        public void Go() => Debug.Log("풀악셀");

        // 엄빠의 추상메서드를 실제 코드 구현, 재 정의
        public override void Left()
        {
            // Base 키워드를 엄빠 멤버에 접근(public, protected)
            Debug.Log(LeftMessage);
        }
    }

    // 똥강아지클래스
    public class LEXUS : Car
    {
        public LEXUS() : this(CarType.내연기관) { }
        public LEXUS(CarType cartype) : base(cartype) { }
    }

    public class Tesla : Car
    {
        public Tesla() : this(CarType.전기) { }
        public Tesla(CarType cartype) : base(cartype) { }
    }

    // sealed(봉인) 키워드를 통해 봉인 클래스 설정 - 
    public class Mirea : Car
    {
        public Mirea() : this(CarType.전기) { }
        public Mirea(CarType cartype) : base(cartype) { }

        public new void Go() => Debug.Log("날아 올라 저 하늘");
    }

    // public class Future : Mirea { }
}