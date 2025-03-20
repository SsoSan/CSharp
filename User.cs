using UnityEngine;

namespace Property
{
    // 고객 정보를 관리하는 클래스
    public class User
    {
        // 필드
        private int birthYear;    // 생년

        // 자동 속성
        public string Name { get; set; }    // 이름

        // 쓰기 전용 속성 - 식
        public int BirthYear
        {
            set
            {
                if(value >= 1900)
                {
                    birthYear = value;
                }
                else
                {
                    birthYear = 0;
                }
            }
        }

        // 읽기 전용 속성 - 계산식
        public int Age
        {
            get
            {
                return (System.DateTime.Now.Year - birthYear);
            }
        }

        // 생성자 - 매개변수를 받아서 속성 초기화
        public User(string name)
        {
            Name = name;
        }
    }
}