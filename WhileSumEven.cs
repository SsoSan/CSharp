using UnityEngine;

//while���� �̿��ؼ� 1���� n(100)������ �����߿��� ¦���� ���� ���ϴ� ���α׷� ����
public class WhileSumEven : MonoBehaviour
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
        while (1 <= n)
        {
            if(i % 2 == 0)
            {
                //�ݺ����๮
                sum = sum + i;

                //������
                i++;
            }
        }

        Debug.Log($"1���� {n}���� ¦���� ���� : {sum}");
    }
}
