using UnityEngine;

//Parameter(�Ű�����)
public class FunctionParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] �Ű������� �ִ� �Լ� ȣ��(���)
        ShowMessage("�ݰ���");

        ShowMessage("�ȳķ�");
    }

    // [1] �Ű������� �ִ� �Լ� ����(����)
    // �Ű������� ���� ���� ���ڿ��� ���
    void ShowMessage(string message)
    {
        Debug.Log(message);
    }
}
