using System.Collections.Generic;
using UnityEngine;

public class DictionaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Dictionary 클래스의 인스턴스 생성 - Dictionary 인터페이스 받기
        //           TKey   TValue - 두가지 필요
        IDictionary<string ,string> data = new Dictionary<string, string>();

        // [2] Dictionary 데이터 넣기
        data.Add("시", "서울특별시");
        data.Add("구", "강동구");

        // [3] Dictionary 데이터 삭제
        data.Remove("시");

        // [4] Dictionary 데이터 넣기 - 인덱서 사용
        data["동"] = "천호동";

        // [5] 키 값은 중복 불가, 같은 키 값으로 추가 불가

    }
}
