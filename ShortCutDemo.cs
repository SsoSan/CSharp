using UnityEngine;

// +=, -=, *=, /=, %=
public class ShortcutDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = 3;
        int b = 5;

        //b변수에 a변수의 값을 누적하라
        //b = b + a;
        b += a;
        Debug.Log(b);   // ?


        //b변수에 a변수의 값을 감산하라
        //b = b - a;
        b -= a;
        Debug.Log(b);   // ?



    }
}