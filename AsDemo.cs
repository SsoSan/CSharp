using UnityEngine;

// as ������ : ~ ���� ��ȯ, ��ȯ�� �Ұ��ϸ� null�� ��ȯ
public class AsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object s = "�׿�������";
        string r1 = s as string;

        Debug.Log($"[1] {r1}");

        object i = 1234;
        string r2 = i as string;

        if (r2 == null)
        {
            Debug.Log("[2] null �ٱ�");
        }

        object i2 = 5678;
        if (i2 is string)
        {
            string r3 = i2 as string;
        }
        else
        {
            Debug.Log("[3] no��ȯ");
        }
    }
}
