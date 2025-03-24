using UnityEngine;

namespace Override
{
    public class Parent
    {
        public void Say() => Debug.Log("엄빠 : 하이룽");
        public void Run() => Debug.Log("엄빠 : 뛰어제껴");
        public virtual void Walk() => Debug.Log("엄빠 : 산책 ㄱ");
    }

    // 새끼클래스
    public class Child : Parent
    {
        public new void Say() => Debug.Log("새끼 : 안냐룽?");
        public new void Run() => Debug.Log("새끼 : 달려라 하니");
        public override void Walk() => Debug.Log("새끼 : 걸어서 서울에서 부산까지");
    }
}