using UnityEngine;

//dowhile���� �̿��ؼ� 1���� n(100)������ �����߿��� Ȧ���� ���� ���ϴ� ���α׷� ����
public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //����� �����ϴ� ����
        int n = 100;
        int sum = 0;

        //�ʱ��
        int i = 1;

        do
        {
            //�ݺ����๮
            if (i % 2 != 0)
            {
                sum = sum + i;
            }
                
            i++;

        } while (1 <= n);

        Debug.Log($"1���� {n}������ ���� : {sum}");
    }
}
