using System;
using UnityEngine;

public class NullDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // null 가능 형식
        //bool bln = null; -> Error
        Nullable<bool> bln = null;

        Debug.Log(bln.HasValue);
        
        bln = false;

        Debug.Log(bln.HasValue);

        // Nullable<int> -> int?
        // Nullable<float> -> float?
        // Nullable<int> ni = null;
        int? ni = null;
        ni = 10;
        Debug.Log(ni);
    }
}
