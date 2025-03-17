using UnityEngine;

namespace PrivatePublic
{
    public class Car
    {
        // 필드(전역변수, 멤버변수) 선언 - Public, Private
        public string name; // 이름
        private int age;    // 나이
        string address;     // 접근제한자가 생략되면 기본값인 private으로 설정

        // 멤버 메서드 - Public, Private
        public void Hi()
        {
            Debug.Log("오하요 - 콘니치와 - 곤방와");
        }

        private void Bye()
        {
            Debug.Log("사요나라");
        }
    }
}