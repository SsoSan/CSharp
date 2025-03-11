using UnityEngine;

public class MethodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hi();
        Hi("�ȳķ�");
        Hi("���縵", 3);
    }

    // �λ��ϴ� �Լ� ���� : Hi
    // �Ű������� ���� �Լ�
    void Hi()
    {
        Debug.Log("�ȳ��ϻ���");
    }

    // �Ű������� �Է¹��� �Լ�(message)�� �λ�
    void Hi(string message)
    {
        Debug.Log(message);
    }

    // �Ű������� �Է¹��� �Լ�(message)�� �Ű������� ���� (count)��ŭ �λ�
    void Hi(string message, int count)
    {
        for(int i = 0; i < count; i++)
        {
            Debug.Log(message);
        }
    }
}
