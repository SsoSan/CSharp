using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;

public class LinqSortList : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 문자열 전용 List 클래스의 인스턴스(객체) 생성 및 초기화
        List<string> colors = new List<string> { "Red", "Blue", "Green" };

        // 내림차순으로 정렬
        var sortedColors = colors.OrderByDescending(c => c);

        foreach (var color in sortedColors)
        {
            Debug.Log(color);
        }
    }
}
