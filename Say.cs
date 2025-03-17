using UnityEngine;

namespace PrivatePublic
{
    public class Say
    {
        // [1] 필드(Field, 멤버변수) 선언 및 초기화
        string message = "ㅎㅇ";

        // [2] 메서드(함수) 선언
        public void Hi()
        {
            this.message = "안녕하니?";

            Debug.Log(this.message);
        }
    }
}