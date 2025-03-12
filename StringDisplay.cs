using UnityEngine;

// 문자열 묶는 방법 (문자열 구미기) : 3가지
public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = "";
        var firstName = "길동";
        var lastName = "홍";

        // [output] "이름 : 홍길동"

        // [1] string 더하기(+) 연산자 사용
        displayName = "이름 : " + lastName + firstName;

        Debug.Log(displayName);

        // [2] string.Format() 메서드 사용
        displayName = string.Format("이름 : {0}{1}", lastName, firstName);

        Debug.Log(displayName);

        // [3] 문자열 보간법 사용
        displayName = $"이름 : {lastName}{firstName}";

        Debug.Log(displayName);
    }
}
