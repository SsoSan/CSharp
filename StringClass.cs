using UnityEngine;

// String == System.String
// ����(��)�� ���� ���ع����� : �迭�̸�.Length
public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hi";
        System.String s2 = "���� ��?";

        Debug.Log($"{s1} ���� : {s1.Length}, {s2} ���� : {s2.Length}");
    }
}
