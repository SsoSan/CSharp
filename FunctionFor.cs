using UnityEngine;

public class FunctionFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] �Լ� ȣ�� : 3��
        Hi();
        Hi();
        Hi();
    }

    // [1] �Լ� �����(����, ����)
    void Hi()
    {
        Debug.Log("�ȳ�");
    }
}
