using UnityEngine;

namespace Override
{
    public class MethodOverrideNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Developer 클래스의 인스턴스 생성
            Developer dev = new Developer();
            Debug.Log(dev);

            WedDeneloper wDev = new WedDeneloper();
            Debug.Log(wDev);

            MobileDeveloper mDev = new MobileDeveloper();
            Debug.Log(mDev);
        }
    }
}