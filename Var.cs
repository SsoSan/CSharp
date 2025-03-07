using UnityEngine;

// var : 암시적으로 형식화된 로컬 변수
// var 선언시 데이터 초기화를 반드시 한다
public class Var : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var name = "홍길동";   //변수에 입력되는 값("홍길동")을 보고 name변수를 string 형식으로 결정
        Debug.Log(name);
        Debug.Log(name.GetType());

        var version = 8.0;    //변수에 입력되는 값(8.0)을 보고 version변수를 double 형식으로 결정
        Debug.Log(version);
        Debug.Log(version.GetType());

        var car = 1;          //변수에 입력되는 값(1)을 보고 car변수를 int 형식으로 결정
        Debug.Log(car);
        Debug.Log(car.GetType());
    }
}