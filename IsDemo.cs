using UnityEngine;

// is ������ : ���� ���ϱ�
public class IsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;
        object o = i;

        Debug.Log(o);

        object obj = 9874;
        int num = (int)obj;
                //  �� ĳ����

        Debug.Log(num);

        object s = "������7";
        object j = 4567;

        if (s is string)
        {
            Debug.Log($"[1] {s} �� null�� �ƴϸ� ���ڿ� �������� ��ȯ�� ����");
        }

        if (j is int)
        {
            Debug.Log($"[2] {j} �� ���������� ��ȯ�� ����");
        }
    }
}

/*
�� ����(value type) : ��ü�� �� ��ü�� ����ִ� ����
���� ����(reference type) : ��ü�� ���� ����ְ� �� �ٸ� ��ü�� �����ͷ� �ٶ󺸴� ����

object ������ ���� : object ������ �������� ��� ������ ������ ���� ����(�Ҵ�) ����
�ڽ�(boxing) : �� ������ �����͸� ���������� �����ͷ� ����
��ڽ�(unboxing) : ���������� �����͸� �� ������ �����ͷ� ���� - ĳ����, ĳ��Ʈ

is ������ : ���� ���ϱ�
 - Ư�� �������� �ƴ����� ��
 - Ư�� �������� ��ȯ�� �����ϸ� true, �׷��� ������ false
*/