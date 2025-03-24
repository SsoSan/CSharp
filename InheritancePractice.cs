using UnityEngine;

namespace Override
{
    public class InheritancePractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // LEXUS 클래스의 인스턴스 생성
            LEXUS lexus = new LEXUS();
            Debug.Log($"{lexus.Style}");
            lexus.Go();
            lexus.Back();
            lexus.Left();

            LEXUS lexusH = new LEXUS(CarType.하이브리드);
            Debug.Log($"{lexusH.Style}");
            lexusH.Go();

            // Tesla 클래스의 인스턴스 생성
            Tesla tesla = new Tesla();
            Debug.Log($"{tesla.Style}");
            tesla.Go();
            tesla.Back();
            tesla.Left();

            // Mirea 클래스의 인스턴스 생성
            Mirea mirea = new Mirea();
            Debug.Log($"{mirea.Style}");
            mirea.Go();
        }
    }
}