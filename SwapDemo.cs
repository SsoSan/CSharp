using UnityEngine;

public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;
        int temp;

        Debug.Log($"처음 값 i: {i}, j: {j}");

        //자리 바꾸기
        temp = i;   //임시변수(temp)에 i값 저장
        i = j;      //i 변수에 j 값 저장
        j = temp;   //j 변수에 임시변수(temp)에 저장되었던 i값을 저장

        Debug.Log($"나중 값 i: {i}, j: {j}");
    }
}

/*
[Q]
+, -, *, / 등의 연산없이 변수 i, j의 값을 서로 바꾸어서 저장하세요
= 만 이용하세요
temp 변수를 만들어서 이용해보세요

[output]
처음 i:100, j:200
변경 i:200, j:100
*/