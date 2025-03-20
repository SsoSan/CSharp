using UnityEngine;

namespace Delegate
{
    public class DelegateDescription : MonoBehaviour
    {
        // [1] Delegate 선언 - Hi
        delegate void SayDelegate();

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // 직접 호출
            Hi();

            // [2] 대리자의 변수 선언 및 대신 할 메서드 1
            SayDelegate say = Hi;

            // 대리자 호출 1
            say();

            // [3] 대리자의 변수 선언 및 대신 할 메서드 2
            SayDelegate hello = new SayDelegate(Hi);

            // 대리자 호출 2
            hello();

            // [4] 대리자의 변수 선언 및 대신 할 메서드 3, 대리자 호출 3
            SayDelegate insa = new SayDelegate(Hi);
            insa.Invoke();
        }

        void Hi()
        {
            Debug.Log("별일없노");
        }
    }
}

/*
Delegate(대리자, 대신 실행자)
 - 등록(지정)한 메서드를 대신 실행
 - 매개변수 목록 및 반환 형식이 있는 메서드를 참조로 나타내는 형식
 - 매개변수, 반환형 없는 메서드를 대신 실행

Delegate 형식

Delegate void 대리자 이름()
*/