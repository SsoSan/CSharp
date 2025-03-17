using UnityEngine;

// 인스턴스 메서드 만들기
public class MyMath
{
    // [1] 두 수의 합을 구하는 (인스턴스) 메서드 정의
    public void Sum(int x, int y)
    {
        int sum = x + y;
        Debug.Log($"두 수의 합계 : {sum}");
    }
}

public class ClassMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] MyMath 클래스의 인스턴스(겍체) 생성
        MyMath myMath = new MyMath();

        // [2] 개체이름.인스턴스 메서드이름 형태로 호출
        myMath.Sum(3, 5);
    }
}
