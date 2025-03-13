using UnityEngine;

// string의 활용
public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // string 변수 str 선언하고 빈값으로 초기화
        string str = "";
        str = System.String.Empty;      // 빈값으로 저장
        str = " Abc DeF FeD Cba ";      // 앞 뒤에 공백 하나씩 넣어서 값 저장

        Debug.Log(str);                 // 기본 출력
        Debug.Log(str.Length);          // 문자열 길이 구하기
        Debug.Log(str[5]);              // 'D' 출력
        Debug.Log(str.ToUpper());       // 대문자로 바꾸기
        Debug.Log(str.ToLower());       // 소문자로 바꾸기

        // 공백 제거
        Debug.Log(str.Trim());          // 앞 뒤 양쪽 공백 제거
        Debug.Log(str.TrimStart());     // 문자열 앞 부분 공백 제거
        Debug.Log(str.TrimEnd());       // 문자열 뒷 부분 공백 제거

        // 검색
        Debug.Log(str.IndexOf('e'));    // e가 위치한 인덱스 가져오기(가장 먼저 나오는 값 찾으면 break)
        Debug.Log(str.Substring(5, 3)); // 문자열 일부 가져오기(5번 인덱스부터 세글자 가져오기)
        Debug.Log(str.Substring(5));    // 5번 인덱스부터 끝까지 가져오기
        Debug.Log(str.Remove(5, 3));    // 5번 인덱스부터 세글자 삭제

        // 비교
        Debug.Log(str[1] == str[15]);   // false
        Debug.Log("ABC".Equals("Abc")); // false
        Debug.Log(System.String.Compare("BAC", "Bac")); // 0(같음), 1(다름, >), -1(다름, <)

        // 연결
        var hi1 = "인생이";
        var hi2 = " 쉽지않다";

        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}{hi2}");
        Debug.Log(System.String.Format("{0}{1}", hi1, hi2));

        // format
        Debug.Log(System.String.Format("{0:C}", 1000));          // 0:C : 화폐 단위
        Debug.Log(System.String.Format("{0:#,###}", 1000000));   // 세자리 콤마

        // 분리하기 / 문자열 전체 공백 제거
        string[] strArray = str.Trim().Split(' ');
        string strALL = "";

        foreach (var s in strArray)
        {
            strALL = strALL + s;
        }

        Debug.Log(strALL);
    }
}
