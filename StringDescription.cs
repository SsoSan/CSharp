using UnityEngine;

// String Ŭ����, StringBuilder Ŭ������ �̿��Ͽ� ���ڿ� �ٷ��
public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ���ڿ� ���� �޼��� - �빮��, �ҹ��� �ٲ������
        string message = "hello World!";

        Debug.Log(message);

        // [1] �빮��
        Debug.Log(message.ToUpper());

        // [2] �ҹ���
        Debug.Log(message.ToLower());

        // [3] �ٲ������
        Debug.Log(message.Replace("hello","�ȳķ�").Replace("World", "�߹�"));
    }
}
