using UnityEngine;

// ��ȯ���� �ִ� �Լ� ����� ȣ��
public class ReturnValue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] ��ȯ���� �ִ� �Լ� ȣ��(���)
        // ��ȯ���� �޾��� ������ �����ϰ� ��ȯ�Ǵ� �� ����
        string returnvalue = GetString();

        Debug.Log(returnvalue);
    }

    // [1] ��ȯ���� �ִ� �Լ� �����(����, ����)
    // ��ȯ�� �̶�� ���ڿ�(string)�� ��ȯ�ϴ� �Լ�
    string GetString()
    {
        return "��ȯ��(Return Value)";
    }
}
