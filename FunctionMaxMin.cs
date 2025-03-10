using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 3, 5�� �Է¹޾� ū �� ���
        int max = GetMax(3, 5);
        Debug.Log($"3�� 5�� ū ���� {max} ��");

        int min = GetMin(-3, -5);
        Debug.Log($"-3�� -5�� ���� ���� {min} ��");
    }

    int GetMax(int x, int y)
    {
        /*
        int maxvalue;
        if (x > y)
        {
            maxvalue = x;
        }
        else
        {
            maxvalue = y;
        }
        return maxvalue;
        */

        /*
        // 3�� ������
        int maxvalue = (x > y) ? x : y;
        return maxvalue;
        */

        //return (x > y) ? x : y; ����Ǯ�����

        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    int GetMin(int x, int y)
    {
        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}

/*
[Q]
1. �Ű������� �Է¹��� �ΰ��� ���� �� ū ���� ��ȯ�ϴ� �Լ�
2. �Ű������� �Է¹��� �ΰ��� ���� �� ���� ���� ��ȯ�ϴ� �Լ�
3. 3, 5�� �Է¹޾� ū �� ���
4. -3, -5�� �Է¹޾� ���� �� ���

[output]
3�� 5�� ū ���� (��ȯ��) �̴�
-3�� -5�� ���� ���� (��ȯ��) �̴�
*/