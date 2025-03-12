using UnityEngine;

// [1] 동물들을 구분하는 열거형 생성
// 열거형 값은 순서대로 0부터 시작해서 1씩 증가
enum Animale
{
    Horse,      // 0
    Sheep = 5,  // 1 -> 5
    Monkey,     // 2 -> 6
}

public class EnumIndexChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((int)Animale.Monkey);
    }
}
