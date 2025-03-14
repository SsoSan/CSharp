using UnityEngine;
using System.Linq;
using System.Collections.Generic;

// Sort : 정렬
public class LinqSort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 문자 배열을 오름차순으로 정렬
        string[] colors = { "Red", "Green", "Blue" };

        // 오름차순
        IEnumerable<string> sortedColor = colors.OrderBy(s => s);

        foreach (var color in sortedColor)
        {
            Debug.Log(color);
        }

        // 내림차순
        IEnumerable<string> sortedColor2 = colors.OrderByDescending(s => s);

        foreach (var color in sortedColor2)
        {
            Debug.Log(color);
        }
    }
}
