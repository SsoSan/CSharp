using UnityEngine;

public class SqureClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Squre 클래스의 정적(static) 메서드 GetName() 호출
        // 정적 메서드 호출 방법 : 클래스 이름(Squre).메서드 이름(GetName()) 
        string name = Squre.GetName();
        Debug.Log(name);
    }
}
