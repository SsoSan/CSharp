using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 리스트 제네릭 클래스 : List<T> => List<int>, List<string>, ..., List<object>
public class ListOfString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] <string> 전용 리스트의 인스턴스 생성
        List<string> colors = new List<string>();

        // [2] 데이터 넣기
        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");

        // [3] 데이터 꺼내기
        foreach (var s in colors)
        {
            Debug.Log(s);
        }

    }
}
