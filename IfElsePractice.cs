using UnityEngine;

public class IfEslePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 65;
        string medal = "";

        //[1]score�� 90�̻��̸� �ݸ޴�
        if (score >= 90)
        {
            medal = "�ݸ޴�";
        }
        else // 0~89
        {
            //[2] 80�̻��̸� ���޴�
            if (score >= 80)
            {
                medal = "���޴�";
            }
            else // 0~79
            {
                //[3] 70 �̻��̸� ���޴�
                if (score >= 70)
                {
                    medal = "���޴�";
                }
                else //0~69
                {
                    medal = "��޴�";
                }
            }
        }

        Debug.Log($"{medal}�� �����Ͽ����ϴ�");
    }
}


/*
[Q]
score�� 90�̻��̸� �ݸ޴� ���, 80�̻��̸� ���޴� ���
70 �̻��̸� ���޴� ���, �׿� �������� ��޴� ���
score�� 85��

[output]
()�� �����Ͽ����ϴ�

*/