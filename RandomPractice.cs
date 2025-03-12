using UnityEngine;

// �ζ� ��ȣ ������
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Random Ŭ������ ��ü ����
        System.Random random = new System.Random();

        // �迭 ���� ���� �� ��Ҽ� ����
        int[] numbers = new int[6];

        int number = 0;     // �������� �����ϴ� ����
        bool flag = false;  // �ߺ� �˻��ؼ� �ߺ��̸� true, �ƴϸ� false

        for (int i = 0; i < 6; i++)
        {
            // 1 ~ 46���� ���� �޾ƿ´�
            number = random.Next(1, 46);

            // �ߺ� üũ - number�� ���� ��µ� ��ȣ ��
            flag = false;
            if(i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;
                    }
                }
            }

            if (flag == false)   // �ߺ��� �ƴϸ�
            {
                numbers[i] = number;
            }
            else   // �ߺ��̸� �ٽ� ����ϱ� ���� �ε����� ����
            {
                i--;
            }
        }

        // �ζǹ�ȣ ���
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log($"�ζǹ�ȣ : [{numbers[i]}]");
        }
    }
}

/*
// �ߺ� ��
numbers[0] = X
numbers[1] = [0]
numbers[2] = [0], [1]
numbers[3] = [0], [1], [2]
numbers[4] = [0], [1], [2], [3]
numbers[5] = [0], [1], [2], [3], [4]
*/

/*
[Q]
�ζ� ��ȣ ������ �����ڰ�
[1] 6�� ��ȣ
[2] 1 ~ 45�� ������ ���� ��ȣ
[3] �ߺ��� ���ڰ� ������ �ʰ�

[output] ���ǿ� �´� ��ȣ 6�� ���
1
2
3
4
5
6
*/