using UnityEngine;

//GetType : 변수의 타입 읽어오기
public class GetTypeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;               //정수형 int
        double d = 3.14;            //실수형 double
        string s = "안녕하세요";     //문자열
        char c = 'A';               //문자

        Debug.Log(i.GetType());
        Debug.Log(d.GetType());
        Debug.Log(s.GetType());
        Debug.Log(c.GetType());

    }
}