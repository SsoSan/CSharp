using UnityEngine;

namespace Inheritance11
{
    public class FieldHiddenDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // SubClass 클래스의 인스턴스 생성
            SubClass sub = new SubClass();
            sub.SetWord("Hide on bush");
            Debug.Log(sub.GetWord());
        }
    }
}