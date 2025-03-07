using UnityEngine;

// index(�ε���) : �� ��°�� ��, [ ] �ȿ� ���� ����, ��
public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // �ױⰡ 3�� ������ �迭 �����ϰ� �ʱ�ȭ
        int[] numbers = { 1, 2, 3 };
        // number[0] -> 1, number[1] -> 2, number[2] -> 3

        // �迭�� index�� �����ϴ� ���� / �׻� 0���� �ʱ�ȭ / index�� ������ 0 ~ n-1(2)
        int index = 0;

        Debug.Log(numbers[index++]);    // 1 : numbers[0] => 1, index: 1
        Debug.Log(numbers[index++]);    // 2 : numbers[1] => 2, index: 2
        Debug.Log(numbers[index++]);    // 3 : numbers[1] => 3, index: 3

        Debug.Log("�ƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢƢ�");

        Debug.Log(numbers[--index]);    // 3 : index: 2 => numbers[2] => 3
        Debug.Log(numbers[--index]);    // 2 : index: 1 => numbers[1] => 2
        Debug.Log(numbers[--index]);    // 1 : index: 0 => numbers[0] => 1

    }
}
