using UnityEngine;

// Korea.Suwon에 있는 클래스를 가져다 사용 하겠음
using Korea.Suwon;

// 별칭을 사용, Korea.Suwon을 Su라고 별칭을 지어 사용
using Su = Korea.Suwon;

public class NameSpaceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 네임스페이스 이름 전체를 지정해서 사용
        Korea.Seoul.Car se = new Korea.Seoul.Car();
        se.Run();   // 서울 자동차가 달리농

        Korea.Suwon.Car su = new Korea.Suwon.Car();
        su.Run();   // 수원 자동차가 달리농

        // [2] 네임스페이스 선언부에 using을 선언하여 사용
        Car seoul = new Car();
        seoul.Run();    // 수원 자동차가 달리농 => using Korea.Suwon; 으로 수원카를 사용하겠다고 선언

        // [3] 별칭을 지정해서 사용
        Su.Car suwon = new Su.Car();
        suwon.Run();    // 수원 자동차가 달리농

        // Truck 클래스 호출
        Korea.Seoul.Truck tr = new Korea.Seoul.Truck();
        tr.Run();   // 서울 트럭이 달리농
    }
}
