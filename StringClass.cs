using UnityEngine;

// String == System.String
// 문자(배)열 길이 구해버리기 : 배열이름.Length
public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hi";
        System.String s2 = "움집 고?";

        Debug.Log($"{s1} 길이 : {s1.Length}, {s2} 길이 : {s2.Length}");
    }
}
