using UnityEngine;

namespace Indexer
{
    public class IndexerDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Catalog 클래스의 인스턴스 생성
            Catalog ca = new Catalog();

            Debug.Log(ca[0]);   // 인스턴스 이름[인덱스] 형태로 사용
            Debug.Log(ca[1]);
            Debug.Log(ca[2]);
            Debug.Log(ca[99]);
        }
    }
}

/*
Indexer(인덱서)
 - 클래스의 인스턴스(객체)를 배열맹키로([ ]) 사용할 수 있도록 해주는 구문
                 ( 인스턴스이름[0], 인스턴스이름[1] )
 - 클래스의 필드(배열, 컬렉션)의 값을 인덱서로 호출해서 사용(읽기, 쓰기) 가능

인덱서 형식
Class Car
Car cars = new Car(99);
cars[0] = "a"
cars[1] = "b"
cars[2] = "c"
*/