using UnityEngine;

// break; : �ݺ���(for, while)���� �ڵ���({ })�� ���������� ��ɹ�
// �ݺ��� �ȿ��� break���� ������ ��� �ݺ����� ���� ����
// "�ȳ��ϼ���"�� 5�� �ϴ� ���α׷� ����
public class BreakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // "�ȳ��ϼ���"�� 5�� �ϴ� ���α׷� ����
        // i = 2�� �� for���� ����
        for (int i = 0; i < 5; i++)
        {
            /*
            if (i == 2)
            {
                break;      <-�ڵ��� ��ġ�� ���� ����� õ������
            }
            */

            // �ݺ����๮
            Debug.Log("�ȳ��ϼ���");

            if (i == 2)
            {
                break;
            }
        }

        // i = 0 �� i < 5(��) �� ��� �� i == 2(����) �� i = 1 �� i < 5(��) �� ���
        // i == 2(����) �� i = 2 �� i < 5(��) �� ��� �� i == 2(��) �� break; �� for�� ����
    }
}
