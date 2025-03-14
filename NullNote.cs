using UnityEngine;

// null 연산자 : ??(null 병합 연산자), ?.(null 조건부 연산자)
public class NullNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ??(null 병합 연산자)
        string nullValue = null;
        string message = "";

        // message 변수 초기화
        /*
        if (nullValue == null)
        {
            message = "null 이면 새로운 값으로 초기화";
        }
        */

        message = nullValue ?? "null 이면 새로운 값으로 초기화";

        Debug.Log(message);

        // ?.(null 조건부 연산자)
        int? len;               // message 길이를 저장하는 변수
        string msg = null;

        /*
        if(msg != null)
        {
            len = msg.Length;
        }
        else
        {
            len = null;
        }
        */

        // messagr가 null이면 null을 반환, null이 아니면 ?. 뒤에 있는 값 반환
        len = msg?.Length;

        msg = "군침이 싹 도노";
        len = msg?.Length;
        Debug.Log(len);
    }
}
