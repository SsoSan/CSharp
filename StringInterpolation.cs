using UnityEngine;

//String Interpolation (문자열 보간법)
public class StringInterpolation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "문자열 보간법";
        Debug.Log("Message: " + message); //[1] 문자열 더하기 연산
        Debug.Log($"Message: {message}"); //[2] 문자열 보간법

        //string.Format
        string msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요");
        Debug.Log(msg);
    }
}