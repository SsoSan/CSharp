using UnityEngine;


public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //dowhile
        //[1]�ʱ��
        int i = 0;

        do
        {
            //�ݺ����๮
            Debug.Log("�ȳ��ϼ���");

            //[2]������
            i++;

          //[3]���ǽ�
        } while (i < 3);

        //i = 0; -> ��� -> i = 1; -> i < 3(��) -> ��� -> i = 2 -> i < 3(��) -> ���
        //i = 3 -> i < 3(����) -> dowhile�� ����
    }
}

/*
dowhile��(�ݺ���)
���� �ݺ����๮ 1�� �����Ѵ�
 - ���ǽ��� true�� �ݺ����� ����
 - ���ǽ��� false�� while�� ����

do
{
    //�ݺ����๮
} while(���ǽ�)
*/