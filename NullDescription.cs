using UnityEngine;

public class NullDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 값 형식
        int i = 0;

        // 참조 형식
        string s = null;
        s = "군침이 싹 도노";

        string empty = "";

        Debug.Log(empty);
        Debug.Log(i);
        Debug.Log(s);
    }
}

/*
Null(NULL, null)
 - 아무것도 없는 상태, 아무것도 없음을 의미하는 리터럴
 - 인스턴스(객체)가 아무것도 참조하지 않음(null 참조)

(값 형식) x 1234
(참조 형식) s ---> "군침이 싹 도노"
(참조 형식) o 
참조형 변수(o)에 아무런 값도 설정하지 않음, null 참조
string의 ""(빈 값, empty) 와 null은 다름
*/