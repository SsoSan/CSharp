using UnityEngine;

// string : 문자(배)열, 문자의 배열
public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string arr = "C#8";

        Debug.Log(arr.Length);  //3

        Debug.Log(arr[0]);  //C
        Debug.Log(arr[1]);  //#
        Debug.Log(arr[2]);  //8
    }
}
