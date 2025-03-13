using UnityEngine;

public class TryCatchFinallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 5;
        int y = 0;
        int r = 0;

        try     // ���ܰ� �߻� �� ���ɼ��� �ִ� ����
        {
            // [1]
            r = x / y;
            Debug.Log($"{x} / {y} = {r}");
        }
        catch   // try ���� ���� ���ܰ� �߻��ϸ� catch ���� ���� ��ɹ��� ����
        {
            // [2]
            Debug.Log("���� �߻��߳�");
        }
        finally // try �������� ����(����) �߻� ������ ������� ����
        {
            // [3]
            Debug.Log("���α׷� ��");
        }

        // try �������� ���ܰ� �߻��ϸ� : [1] => [2] => [3]
        // try �������� ���ܰ� �߻����� ������ : [1] => [3]
    }
}
