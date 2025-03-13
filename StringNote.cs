using UnityEngine;

// string�� Ȱ��
public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // string ���� str �����ϰ� ������ �ʱ�ȭ
        string str = "";
        str = System.String.Empty;      // ������ ����
        str = " Abc DeF FeD Cba ";      // �� �ڿ� ���� �ϳ��� �־ �� ����

        Debug.Log(str);                 // �⺻ ���
        Debug.Log(str.Length);          // ���ڿ� ���� ���ϱ�
        Debug.Log(str[5]);              // 'D' ���
        Debug.Log(str.ToUpper());       // �빮�ڷ� �ٲٱ�
        Debug.Log(str.ToLower());       // �ҹ��ڷ� �ٲٱ�

        // ���� ����
        Debug.Log(str.Trim());          // �� �� ���� ���� ����
        Debug.Log(str.TrimStart());     // ���ڿ� �� �κ� ���� ����
        Debug.Log(str.TrimEnd());       // ���ڿ� �� �κ� ���� ����

        // �˻�
        Debug.Log(str.IndexOf('e'));    // e�� ��ġ�� �ε��� ��������(���� ���� ������ �� ã���� break)
        Debug.Log(str.Substring(5, 3)); // ���ڿ� �Ϻ� ��������(5�� �ε������� ������ ��������)
        Debug.Log(str.Substring(5));    // 5�� �ε������� ������ ��������
        Debug.Log(str.Remove(5, 3));    // 5�� �ε������� ������ ����

        // ��
        Debug.Log(str[1] == str[15]);   // false
        Debug.Log("ABC".Equals("Abc")); // false
        Debug.Log(System.String.Compare("BAC", "Bac")); // 0(����), 1(�ٸ�, >), -1(�ٸ�, <)

        // ����
        var hi1 = "�λ���";
        var hi2 = " �����ʴ�";

        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}{hi2}");
        Debug.Log(System.String.Format("{0}{1}", hi1, hi2));

        // format
        Debug.Log(System.String.Format("{0:C}", 1000));          // 0:C : ȭ�� ����
        Debug.Log(System.String.Format("{0:#,###}", 1000000));   // ���ڸ� �޸�

        // �и��ϱ� / ���ڿ� ��ü ���� ����
        string[] strArray = str.Trim().Split(' ');
        string strALL = "";

        foreach (var s in strArray)
        {
            strALL = strALL + s;
        }

        Debug.Log(strALL);
    }
}
