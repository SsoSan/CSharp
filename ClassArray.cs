using UnityEngine;

// 인스턴스 배열 만들기
// 특정 클래스 형식의 배열 선언 => 배열 요소들의 각각 인스턴스를 생성 후 사용

public class CategoryClass
{
    public void Print(int i) => Debug.Log($"카테고리 {i}");
}

public class ClassArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] CategoryClass 클래스의 배열 선언
        CategoryClass[] categories = new CategoryClass[3];

        // [2] 배열 요소들의 각각 인스턴스를 생성
        categories[0] = new CategoryClass();
        categories[1] = new CategoryClass();
        categories[2] = new CategoryClass();

        // [3] 사용
        for (int i = 0; i < categories.Length; i++)
        {
            categories[i].Print(i);
        }
    }
}
