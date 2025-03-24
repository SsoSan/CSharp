using UnityEngine;

namespace Override
{
    // 엄빠클래스
    public class Base
    {
        public virtual void Work() => Debug.Log("엄빠 : 돈 벌어온다~");
    }

    // 새끼클래스
    public class Sub : Base
    {
        // sealed 키워드를 사용하여 멤버를 봉인(재 정의 금지)
        public override sealed void Work()
        {
            Debug.Log("새끼 : 나도 돈 벌어오께~");
        }
    }

    // 똥강아지클래스
    public class GrandSub : Sub
    {
        /*
        public override void Work()
        {
            Debug.Log("똥강아지 : 나는 공부하고 올게~");
        }
        */

        public void Play() => Debug.Log("똥강아지 : 아니? 난 놀것이여");
    }
}