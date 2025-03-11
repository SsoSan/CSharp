using UnityEngine;

// [1] �켱������ �����ϴ� ������ ����(����, �����)
// ����� ���� ������ ����
enum Priorty
{
    High,
    Normal,
    Low,
}

public class EnumerationDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] ������ ���� ���� �� �ʱ�ȭ
        // ������ ������ ����Ǵ� ���� ���ǿ��� ������� ��� ���� ����
        Priorty high = Priorty.High;
        Priorty normal = Priorty.Normal;
        Priorty low = Priorty.Low;

        Debug.Log($"{high}, {normal}, {low}");
    }
}

/*
Enumeration(������) : �ϳ��� �̸����� ���� �����ִ� ���� ���� ������ ������� ����

// ����
enum (enum �̸�)
{
    �����,
    �����,
    �����,
    ...
}
*/