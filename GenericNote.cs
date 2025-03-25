using UnityEngine;
using System.Collections.Generic;

namespace GenericClass
{
    public class GenericNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Cup 클래스의 인스턴스 생성
            // Cup cup = new Cup();
            // [1] T에 string을 지정하여 문자열을 저장하는 속성 생성
            Cup<string> text = new Cup<string>();
            text.Contents = "문자열";
            // text.Contents = 1234;

            // [2] T에 int를 지정하여 정수형 숫자를 저장하는 속성 생성
            Cup<int> number = new Cup<int>();
            number.Contents = 1234;
            // number.Contents = "문자열";

            Debug.Log($"{text.Contents} - {number.Contents}");

            // [3] T에 Water(사용자 정의 데이터 형식)를 지정하면 물을 저장하는 속성 생성
            Cup<Water> water = new Cup<Water>();
            water.Contents = new Water();

            Debug.Log(water.Contents.ToString());

            Cup<Coffee> coffee = new Cup<Coffee>();
            coffee.Contents = new Coffee();
            coffee.PrintData(coffee.Contents);
        }
    }
}