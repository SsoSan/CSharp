using UnityEngine;

//while���� �̿��ؼ� 1���� n(100)������ ���� ���ϴ� ���α׷� ����
public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //����� �����ϴ� ����
        int n = 100;
        int sum = 0;

        //�ʱ��
        int i = 1;

        //���ǽ�
        while (i <= n)
        {
            //�ݺ����๮
            sum = sum + i;

            //������
            i++;
        }

        Debug.Log($"1���� {n}������ ���� : {sum}");
    }
}
