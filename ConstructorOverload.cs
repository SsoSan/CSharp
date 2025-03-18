using UnityEngine;

namespace Constructor
{
    public class ConstructorOverload : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // ConstructorLog 클래스의 인스턴스 생성
            ConstructorLog log1 = new ConstructorLog();
            ConstructorLog log2 = new ConstructorLog("홍길동");
            ConstructorLog log3 = new ConstructorLog("백두산");
        }
    }
}