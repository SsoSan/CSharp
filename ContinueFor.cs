using UnityEngine;

// continue�� : �ݺ������� continue���� ������ continue�� �Ʒ��� �ִ� ���๮�� �������� �ʰ�
// ���� �ݺ����� ���ǽ��� �Ǻ��� ���� �ݺ����� ����
public class ContinueFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // "1���� 5����" Ȧ���� ��� �ϴ� ���α׷� ����
        /*
        for (int i = 1; i <= 5; i++)
        {
            //Ȧ���Ǻ���
            if(i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
        */

        for (int i = 1; i <= 5; i++)
        {
            //¦���Ǻ���
            if (i % 2 == 0)
            {
                //���� �ݺ� �������� �ݺ����� �����ϰ� ���� �ݺ������� �̵�
                continue;
            }
            
            Debug.Log(i);
        }

    }
}
