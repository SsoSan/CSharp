using UnityEngine;

public class ClassTwo : MonoBehaviour
{
    // 정적(ststic) 멤버 메서드
    public static void Hi()
    {
        Debug.Log("콘니치와");
    }

    // 인스턴스(instance) 멤버 메서드 - static 없는 메서드
    public void Hello()
    {
        Debug.Log("마타 아이마쇼");
    }
}
